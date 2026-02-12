import { Component } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {
  AcademicYearLookupEndpointService
} from '../../../../../endpoints/lookup-endpoints/academic-year-lookup-endpoint.service';
import {
  SemesterCreateEndpointService, SemesterCreateRequest
} from '../../../../../endpoints/semester-endpoints/semester-create-endpoint.service';
import {MatSnackBar} from '@angular/material/snack-bar';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-student-semesters-new',
  standalone: false,

  templateUrl: './student-semesters-new.component.html',
  styleUrl: './student-semesters-new.component.css'
})
export class StudentSemestersNewComponent {
    studentId: number;
    semesterForm: FormGroup;
    academicYears: any[] = [];

    constructor(private route: ActivatedRoute,
                private router: Router,
                private AcademicYearLookupEndpointService: AcademicYearLookupEndpointService,
                private snackBar: MatSnackBar,
                private fb: FormBuilder,
                private SemesterCreateEndpointService: SemesterCreateEndpointService){
      this.studentId = this.route.snapshot.params["id"];
      this.semesterForm = this.fb.group({
        studyYear: [null, [Validators.required]],
        enrollmentDate: [new Date().toISOString().substring(0, 10), [Validators.required]],
        academicYearId: [1, [Validators.required]],


      });
    }

    ngOnInit() {
      this.loadAy();
    }

  loadAy() {
    this.AcademicYearLookupEndpointService.handleAsync().subscribe({
      next: (response: any[]) => {
        this.academicYears = response.map(x => {
          return {
            id: x.id,
            name: x.description
          };
        });
      },
      error: (error: any) => {
        this.snackBar.open('Error loading AY', 'Close', { duration: 5000 });
        console.error('Error loading AY', error);
      }
    });
  }

  protected saveSemester() {
      if(this.semesterForm.invalid) return;

      const studentData : SemesterCreateRequest = {
        ...this.semesterForm.value
      };
      this.SemesterCreateEndpointService.handleAsync1(this.studentId, studentData).subscribe({
        next: () => {
          this.snackBar.open('Semester Saved Successfully', 'Close', {duration : 5000});
          this.router.navigate(['admin/students', this.studentId, 'semesters']);
        },
        error: (error) => {
          const message = error.error?.error || 'Došlo je do greške prilikom spremanja';
          this.snackBar.open(message, 'Close', {duration : 5000});
          console.error('Error saving semester', error);
        }
      })
    }
}
