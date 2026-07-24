import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-course-card',
  standalone: true,
  imports: [],
  templateUrl: './course-card.html',
  styleUrl: './course-card.css'
})
export class CourseCard implements OnChanges {

  @Input() course: any;

  ngOnChanges(changes: SimpleChanges): void {

    console.log('Previous:', changes['course']?.previousValue);

    console.log('Current:', changes['course']?.currentValue);

  }

}