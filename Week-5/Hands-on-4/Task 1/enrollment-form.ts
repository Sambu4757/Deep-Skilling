import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, NgForm } from '@angular/forms';

@Component({
  selector: 'app-enrollment-form',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule
  ],
  templateUrl: './enrollment-form.html',
  styleUrl: './enrollment-form.css'
})
export class EnrollmentForm {

  studentName: string = '';
  studentEmail: string = '';
  courseId: number | null = null;
  preferredSemester: string = '';
  agreeToTerms: boolean = false;

  submitted: boolean = false;

  onSubmit(form: NgForm): void {

    console.log('Form Value:', form.value);
    console.log('Form Valid:', form.valid);

    this.submitted = true;

  }

}