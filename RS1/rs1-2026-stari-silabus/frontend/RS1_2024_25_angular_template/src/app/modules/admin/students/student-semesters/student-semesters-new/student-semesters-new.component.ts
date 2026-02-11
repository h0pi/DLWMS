import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {
  AcademicYearLookupEndpointService, AcademicYearLookupResponse
} from '../../../../../endpoints/lookup-endpoints/academic-year-lookup-endpoint.service';
import {MatSnackBar} from '@angular/material/snack-bar';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {
  SemesterUpdateOrInsertEndpointService,
  SemesterUpdateOrInsertRequest
} from '../../../../../endpoints/semester-endpoints/semester-update-insert-endpoint.service';

@Component({
  selector: 'app-student-semesters-new',
  standalone: false,

  templateUrl: './student-semesters-new.component.html',
  styleUrl: './student-semesters-new.component.css'
})
export class StudentSemestersNewComponent implements OnInit {
  studentId : number;
  semesterForm: FormGroup;
  academicYears: AcademicYearLookupResponse[] = [];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private AcademicYearLookupEndpointService: AcademicYearLookupEndpointService,
    private snackBar: MatSnackBar,
    private fb: FormBuilder,
    private SemesterUpdateOrInsertEndpointService: SemesterUpdateOrInsertEndpointService,
  ) {
    this.studentId = this.route.snapshot.params["id"];
    this.semesterForm = this.fb.group({
      studyYear: [null, [Validators.required]],
      enrollmentDate: [new Date(), [Validators.required]],
      academicYearId: [1, [Validators.required]],
    });
  }
  ngOnInit(): void {
    this.loadAY();
  }

  loadAY(): void {
    this.AcademicYearLookupEndpointService.handleAsync().subscribe({
      next: (academicYears: AcademicYearLookupResponse[]) => {
        this.academicYears = academicYears;
      },
      error: (error) => {
        this.snackBar.open('Error loading AY. Please try again.', 'Close', { duration: 5000 });
        console.error('Error loading AY', error);
      },
    });
  }

  protected saveSemester() {
    if (this.semesterForm.invalid) return;

    const studentData: SemesterUpdateOrInsertRequest = {
      ...this.semesterForm.value,
    };

    this.SemesterUpdateOrInsertEndpointService.handleAsync1(this.studentId, studentData).subscribe({
      next: () => {
        this.snackBar.open('Semester saved successfully!', 'Close', { duration: 5000 });
        this.router.navigate(['/admin/students', this.studentId, 'semesters']);
      },
      error: (error) => {
        this.snackBar.open('Error saving semester. Please try again.', 'Close', { duration: 5000 });
        console.error('Error saving semester', error);
      },
    });
  }
}
