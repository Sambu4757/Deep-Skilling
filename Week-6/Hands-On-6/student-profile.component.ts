constructor(private enrollmentService:EnrollmentService){}

enrolledCourses:any[]=[];

ngOnInit(){

this.enrolledCourses=
this.enrollmentService.getEnrolledCourses();

}
