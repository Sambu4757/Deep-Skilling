constructor(private courseService: CourseService){}

ngOnInit(){

this.courses=this.courseService.getCourses();

}
