import { Component, OnInit } from '@angular/core';
import {
  FormArray,
  FormBuilder,
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
  AbstractControl,
  ValidationErrors
} from '@angular/forms';

@Component({
  selector: 'app-reactive-enrollment-form',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './reactive-enrollment-form.component.html',
  styleUrls: ['./reactive-enrollment-form.component.css']
})
export class ReactiveEnrollmentFormComponent implements OnInit {

  enrollForm!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit() {

    this.enrollForm = this.fb.group({

      studentName: ['', [Validators.required, Validators.minLength(3)]],

      studentEmail: ['', [Validators.required, Validators.email]],

      courseId: ['', [Validators.required, this.courseValidator]],

      preferredSemester: ['Odd', Validators.required],

      agreeToTerms: [false, Validators.requiredTrue],

      additionalCourses: this.fb.array([])

    });

  }

  courseValidator(control: AbstractControl): ValidationErrors | null {

    if (control.value === 'XX101') {
      return { invalidCourse: true };
    }

    return null;
  }

  get additionalCourses(): FormArray {

    return this.enrollForm.get('additionalCourses') as FormArray;

  }

  addCourse() {

    this.additionalCourses.push(new FormControl('', Validators.required));

  }

  removeCourse(index: number) {

    this.additionalCourses.removeAt(index);

  }

  onSubmit() {

    console.log(this.enrollForm.value);

    console.log(this.enrollForm.getRawValue());

  }

}
