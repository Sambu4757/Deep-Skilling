courses: Course[] = [];

errorMessage = '';

ngOnInit() {

  this.courseService.getCourses().subscribe({

    next: data => {

      this.courses = data;

    },

    error: err => {

      this.errorMessage = err.message;

    },

    complete: () => {

      this.isLoading = false;

    }

  });

}
