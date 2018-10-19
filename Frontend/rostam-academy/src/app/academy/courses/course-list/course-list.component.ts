import { Component, OnInit } from '@angular/core';
import { Course } from '../shared/course.model';
import { CourseGridService } from 'src/app/academy/courses/shared/course.service';
import { Observable } from 'rxjs';
import { State } from '@progress/kendo-data-query';
import { DataStateChangeEvent, GridDataResult } from '@progress/kendo-angular-grid';

@Component({
    selector: 'course-list',
    templateUrl: './course-list.component.html',
})
export class CourseListComponent implements OnInit {

    private courses: Observable<GridDataResult>;
    public state: State = {
        skip: 0,
        take: 5
    };
    constructor(private courseGridService: CourseGridService) {
       this.courses = courseGridService;
    }

    public dataStateChange(state: DataStateChangeEvent): void {
        this.state = state;
        debugger;
        this.courseGridService.reload(this.state);
    }

    ngOnInit(): void {
        this.courseGridService.reload(this.state);
    }
}
