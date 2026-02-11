import {Component, OnInit, ViewChild} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {
  SemesterGetAllEndpointService,
  SemesterGetAllResponse
} from '../../../../endpoints/semester-endpoints/semester-get-all-endpoint.service';
import {MatTableDataSource} from '@angular/material/table';
import {MyDialogConfirmComponent} from '../../../shared/dialogs/my-dialog-confirm/my-dialog-confirm.component';
import {MatDialog} from '@angular/material/dialog';
import {StudentGetAllResponse} from '../../../../endpoints/student-endpoints/student-get-all-endpoint.service';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MySnackbarHelperService} from '../../../shared/snackbars/my-snackbar-helper.service';
import {SemesterDeleteEndpointService} from '../../../../endpoints/semester-endpoints/semester-delete-endpoint.service';
import {
  SemesterRestoreEndpointService
} from '../../../../endpoints/semester-endpoints/semester-restore-endpoint.service';
import {debounceTime, distinctUntilChanged, filter, Subject} from 'rxjs';
import {map, tap} from 'rxjs/operators';

@Component({
  selector: 'app-student-semesters',
  standalone: false,

  templateUrl: './student-semesters.component.html',
  styleUrl: './student-semesters.component.css'
})
export class StudentSemestersComponent implements OnInit {
  studentId: number;
  dataSource: MatTableDataSource<SemesterGetAllResponse> = new MatTableDataSource<SemesterGetAllResponse>();
  semesters: SemesterGetAllResponse[] = [];
  displayedColumns: string[] = ['academicYearDesc', 'studyYear', 'enrollmentDate', 'isRenewal','tuitionFee','actions'];
  status: string = '';

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  private searchSubject: Subject<string> = new Subject();

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private dialog: MatDialog,
    private snackbar: MySnackbarHelperService,
    private  semesterGetAllEndpointService: SemesterGetAllEndpointService,
    private  SemesterDeleteEndpointService: SemesterDeleteEndpointService,
    private  SemesterRestoreEndpointService: SemesterRestoreEndpointService


  ) {
    this.studentId = this.route.snapshot.params["id"];
  }
  ngOnInit(): void {
    this.initSearchListener();
    this.getSemesters();
  }

  noviSemestar() {
    this.router.navigate(['/admin/students', this.studentId, 'semesters','new']);
  }

  protected openMyConfirmDialog(id:number, isDelete: boolean) {
    const dialogRef = this.dialog.open(MyDialogConfirmComponent, {
      width: '350px',
      data: {
        title: isDelete? 'Confirm Delete' : 'Confirm Restore',
        message: isDelete? 'Are you sure you want to delete this semester?' : 'Are you sure you want to restore this semester?'
      }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result && isDelete) {
        this.deleteSemester(id);
      } else if (result && !isDelete) {
        this.restoreSemester(id);
      }
    });
  }
  initSearchListener(): void {
    this.searchSubject.pipe(
      debounceTime(300), // Vrijeme čekanja (300ms)
      distinctUntilChanged(), // Emittuje samo ako je vrijednost promijenjena,
      map(v => v.toLowerCase()),
      filter(x => x.length === 0 || x.length >= 3)
    ).subscribe((filterValue) => {
      this.paginator.pageIndex = 0;
      this.getSemesters(filterValue, 1, this.paginator.pageSize);
    });
  }

  applyFilter(event: Event): void {
    const filterValue = (event.target as HTMLInputElement).value.trim().toLowerCase();
    this.searchSubject.next(filterValue); // Prosljeđuje vrijednost Subject-u
  }

  getSemesters(filter: string = '', page: number = 1, pageSize: number = 5): void {
    console.log('Sending request with q:', filter);
    this.semesterGetAllEndpointService.handleAsync1(this.studentId,{
      status: this.status,
      q: filter,
      pageNumber: page,
      pageSize: pageSize
    })
      .pipe(tap(x => console.log("totalCount: " + x.dataItems.length)))
      .subscribe({
        next: (data) => {
          this.dataSource = new MatTableDataSource<SemesterGetAllResponse>(data.dataItems);
          this.paginator.length = data.totalCount;
        },
        error: (err) => {
          this.snackbar.showMessage('Error fetching semesters. Please try again.', 5000);
          console.error('Error fetching semesters:', err);
        }
      });
  }

  deleteSemester(id: number): void {
    this.SemesterDeleteEndpointService.handleAsync(id).subscribe({
      next: () => {
        this.snackbar.showMessage('Semester successfully deleted.');
        this.getSemesters(); // Refresh the list after deletion
      },
      error: (err) => {
        this.snackbar.showMessage('Error deleting semester. Please try again.', 5000);
        console.error('Error deleting semester:', err);
      }
    });
  }

  restoreSemester(id: number): void {
    this.SemesterRestoreEndpointService.handleAsync(id).subscribe({
      next: () => {
        this.snackbar.showMessage('Semester successfully restored.');
        this.getSemesters(); // Refresh the list after deletion
      },
      error: (err) => {
        this.snackbar.showMessage('Error restoring semester. Please try again.', 5000);
        console.error('Error restoring semester:', err);
      }
    });
  }
}
