import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';

import * as CourseActions from '../../store/course/course.actions';

import {

selectAllCourses

} from '../../store/course/course.selectors';

courses$!: Observable<any[]>;

constructor(private store: Store){}

ngOnInit(){

this.courses$=

this.store.select(selectAllCourses);

this.store.dispatch(

CourseActions.loadCourses()

);

}
