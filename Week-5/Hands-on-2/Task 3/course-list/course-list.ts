import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CommonModule, CourseCard],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList {

  courses = [
    { id: 101, name: 'Angular', code: 'ANG101', credits: 4 },
    { id: 102, name: 'Java', code: 'JAVA102', credits: 3 },
    { id: 103, name: 'AWS', code: 'AWS103', credits: 2 },
    { id: 104, name: 'Python', code: 'PY104', credits: 4 },
    { id: 105, name: 'Machine Learning', code: 'ML105', credits: 5 }
  ];

  selectedCourseId: number | null = null;

  onEnroll(courseId: number) {
    console.log('Enrolling in course: ' + courseId);
    this.selectedCourseId = courseId;
  }

}