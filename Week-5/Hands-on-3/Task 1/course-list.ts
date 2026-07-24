import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CommonModule, CourseCard],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList implements OnInit {

  isLoading: boolean = true;

  selectedCourseId: number | null = null;

  courses = [
    {
      id: 101,
      name: 'Angular',
      code: 'ANG101',
      credits: 4,
      gradeStatus: 'passed'
    },
    {
      id: 102,
      name: 'Java',
      code: 'JAVA102',
      credits: 3,
      gradeStatus: 'failed'
    },
    {
      id: 103,
      name: 'AWS',
      code: 'AWS103',
      credits: 2,
      gradeStatus: 'pending'
    },
    {
      id: 104,
      name: 'Python',
      code: 'PY104',
      credits: 4,
      gradeStatus: 'passed'
    },
    {
      id: 105,
      name: 'Machine Learning',
      code: 'ML105',
      credits: 5,
      gradeStatus: 'pending'
    }
  ];

  ngOnInit(): void {

    setTimeout(() => {
      this.isLoading = false;
      console.log('Courses Loaded');
    }, 1500);

  }

  onEnroll(courseId: number): void {

    console.log('Enrolling in course:', courseId);

    this.selectedCourseId = courseId;

  }

  // trackBy improves performance because Angular reuses DOM
  // elements instead of recreating them every time the list changes.
  trackByCourseId(index: number, course: any): number {

    return course.id;

  }

}