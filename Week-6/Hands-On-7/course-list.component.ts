constructor(
private router:Router,
private route:ActivatedRoute
){}


viewCourse(course:any){

this.router.navigate(['courses',course.id]);

}

const search=this.route.snapshot.queryParamMap.get('search');

console.log(search);
