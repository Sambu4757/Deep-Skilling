import { provideMockStore } from '@ngrx/store/testing';

beforeEach(async()=>{

await TestBed.configureTestingModule({

imports:[CourseListComponent],

providers:[

provideMockStore({

initialState:{

course:{

courses:[

{

id:1,

name:'Angular',

code:'ANG101',

credits:4,

gradeStatus:'passed'

}

],

loading:false,

error:null

}

}

})

]

}).compileComponents();

});
