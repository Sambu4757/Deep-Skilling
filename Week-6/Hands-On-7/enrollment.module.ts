import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnrollmentRoutingModule } from './enrollment-routing.module';

import { EnrollmentFormComponent } from '../../pages/enrollment-form/enrollment-form.component';
import { ReactiveEnrollmentFormComponent } from '../../pages/reactive-enrollment-form/reactive-enrollment-form.component';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    EnrollmentRoutingModule,
    EnrollmentFormComponent,
    ReactiveEnrollmentFormComponent
  ]
})
export class EnrollmentModule { }
