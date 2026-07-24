constructor(private courseService:CourseService){}

totalCourses=0;

ngOnInit(){

this.totalCourses=this.courseService.getCourses().length;

}
