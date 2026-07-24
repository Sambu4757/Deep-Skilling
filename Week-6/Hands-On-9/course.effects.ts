import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import * as CourseActions from './course.actions';
import { CourseService } from '../../services/course.service';
import { catchError, map, of, switchMap } from 'rxjs';

@Injectable()
export class CourseEffects {

  constructor(

    private actions$: Actions,

    private courseService: CourseService

  ) {}

  loadCourses$ = createEffect(() =>

    this.actions$.pipe(

      ofType(CourseActions.loadCourses),

      switchMap(() =>

        this.courseService.getCourses().pipe(

          map(courses =>

            CourseActions.loadCoursesSuccess({ courses })

          ),

          catchError(error =>

            of(CourseActions.loadCoursesFailure({

              error: error.message

            }))

          )

        )

      )

    )

  );

}
