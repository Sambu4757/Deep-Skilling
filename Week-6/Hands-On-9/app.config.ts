import { provideStore } from '@ngrx/store';
import { provideEffects } from '@ngrx/effects';
import { provideStoreDevtools } from '@ngrx/store-devtools';

import { courseReducer } from './store/course/course.reducer';
import { CourseEffects } from './store/course/course.effects';

export const appConfig = {

  providers: [

    provideStore({

      course: courseReducer

    }),

    provideEffects([CourseEffects]),

    provideStoreDevtools({

      maxAge:25

    })

  ]

};
