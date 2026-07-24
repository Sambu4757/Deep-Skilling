import { ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { CourseCardComponent } from './course-card.component';

describe('CourseCardComponent', () => {

  let component: CourseCardComponent;
  let fixture: ComponentFixture<CourseCardComponent>;

  beforeEach(async () => {

    await TestBed.configureTestingModule({
      imports: [CourseCardComponent]
    }).compileComponents();

    fixture = TestBed.createComponent(CourseCardComponent);
    component = fixture.componentInstance;

  });

  it('should create', () => {

    expect(component).toBeTruthy();

  });

  it('should display course name', () => {

    component.course = {

      id:1,

      name:'Data Structures',

      code:'CS101',

      credits:4,

      gradeStatus:'passed'

    };

    fixture.detectChanges();

    const h3 = fixture.debugElement.query(By.css('h3'));

    expect(h3.nativeElement.textContent)
      .toContain('Data Structures');

  });

  it('should emit enroll event', () => {

    component.course = {

      id:1,

      name:'Angular',

      code:'ANG101',

      credits:4,

      gradeStatus:'passed'

    };

    spyOn(component.enrollRequested,'emit');

    fixture.detectChanges();

    fixture.debugElement
      .query(By.css('button'))
      .nativeElement.click();

    expect(component.enrollRequested.emit)
      .toHaveBeenCalledWith(1);

  });

});
