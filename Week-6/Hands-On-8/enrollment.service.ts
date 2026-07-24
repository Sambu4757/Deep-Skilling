import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EnrollmentService {

  private enrollmentUrl = 'http://localhost:3000/enrollments';
  private studentsUrl = 'http://localhost:3000/students';

  constructor(private http: HttpClient) { }

  // Get all enrollments
  getEnrollments(): Observable<any[]> {
    return this.http.get<any[]>(this.enrollmentUrl);
  }

  // Enroll a student
  enrollStudent(enrollment: any): Observable<any> {
    return this.http.post<any>(this.enrollmentUrl, enrollment);
  }

  // Delete an enrollment
  deleteEnrollment(id: number): Observable<any> {
    return this.http.delete(`${this.enrollmentUrl}/${id}`);
  }

  // Used in Task 87 (switchMap example)
  getStudentsByCourse(courseId: number): Observable<any[]> {
    return this.http.get<any[]>(
      `${this.studentsUrl}?courseId=${courseId}`
    );
  }
}
