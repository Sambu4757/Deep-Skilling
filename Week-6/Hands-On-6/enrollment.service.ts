import { Injectable } from '@angular/core';
import { CourseService } from './course.service';

@Injectable({
  providedIn: 'root'
})
export class EnrollmentService {

  private enrolledCourseIds: number[] = [];

  constructor(private courseService: CourseService) {}

  enroll(id: number) {
    if (!this.enrolledCourseIds.includes(id))
      this.enrolledCourseIds.push(id);
  }

  unenroll(id: number) {
    this.enrolledCourseIds =
      this.enrolledCourseIds.filter(x => x !== id);
  }

  isEnrolled(id: number) {
    return this.enrolledCourseIds.includes(id);
  }

  getEnrolledCourses() {

    return this.enrolledCourseIds
      .map(id => this.courseService.getCourseById(id))
      .filter(course => course !== undefined);

  }

}
