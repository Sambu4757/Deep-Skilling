import { TestBed } from '@angular/core/testing';

import {

HttpClientTestingModule,

HttpTestingController

} from '@angular/common/http/testing';

import { CourseService } from './course.service';

describe('CourseService',()=>{

let service:CourseService;

let httpMock:HttpTestingController;

beforeEach(()=>{

TestBed.configureTestingModule({

imports:[HttpClientTestingModule]

});

service=TestBed.inject(CourseService);

httpMock=TestBed.inject(HttpTestingController);

});

afterEach(()=>{

httpMock.verify();

});

it('should load courses',()=>{

const mockCourses=[

{

id:1,

name:'Angular',

code:'ANG101',

credits:4,

gradeStatus:'passed'

},

{

id:2,

name:'Java',

code:'JAVA101',

credits:3,

gradeStatus:'pending'

}

];

service.getCourses().subscribe(courses=>{

expect(courses.length).toBe(2);

});

const req=httpMock.expectOne(

'http://localhost:3000/courses'

);

expect(req.request.method).toBe('GET');

req.flush(mockCourses);

});

});
