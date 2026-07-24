import { Routes } from '@angular/router';

export const routes: Routes = [

  { path: '', component: HomeComponent },

  { path: 'courses', component: CourseListComponent },

  { path: 'courses/:id', component: CourseDetailComponent },

  { path: 'profile', component: StudentProfileComponent, canActivate: [authGuard] },

  { path: '**', component: NotFoundComponent }

];
