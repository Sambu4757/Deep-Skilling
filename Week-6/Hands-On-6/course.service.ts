import { Injectable } from '@angular/core';
import { Course } from '../models/course.model';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  private courses: Course[] = [

    { id: 1, name: 'Angular', code: 'ANG101', credits: 4, gradeStatus: 'passed' },

    { id: 2, name: 'Java', code: 'JAVA101', credits: 3, gradeStatus: 'pending' },

    { id: 3, name: 'SQL', code: 'SQL101', credits: 2, gradeStatus: 'failed' },

    { id: 4, name: 'Spring', code: 'SPR101', credits: 4, gradeStatus: 'passed' },

    { id: 5, name: 'React', code: 'RE101', credits: 3, gradeStatus: 'pending' }

  ];

  getCourses() {
    return this.courses;
  }

  getCourseById(id: number) {
    return this.courses.find(c => c.id === id);
  }

  addCourse(course: Course) {
    this.courses.push(course);
  }

}
