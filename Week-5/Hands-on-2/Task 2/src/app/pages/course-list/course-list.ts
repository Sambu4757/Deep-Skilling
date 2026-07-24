import { Component } from '@angular/core';
import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CourseCard],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList {

  courses = [
    { name: 'Angular', instructor: 'John' },
    { name: 'Java', instructor: 'David' },
    { name: 'AWS', instructor: 'Smith' }
  ];

}