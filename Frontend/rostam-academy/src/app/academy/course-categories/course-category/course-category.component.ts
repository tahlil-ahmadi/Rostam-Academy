import { Component, Input, OnInit, SimpleChanges, OnChanges } from '@angular/core';
import { DialogRef } from '@progress/kendo-angular-dialog';
import { OK, Cancel } from '../../dialog-response.enum';
import { CourseCategory } from '../shared/course-category.model';
import { CourseCategoryService } from '../shared/course-category.service';
import { Course } from '../../courses/shared/course.model';

@Component({
    selector: 'course-category',
    templateUrl: './course-category.component.html',
})
export class CourseCategoryComponent implements OnInit {
 
    @Input()
    public model:CourseCategory;
    constructor(private dialog: DialogRef, private service:CourseCategoryService) {
    }
    ngOnInit(): void {
        if (this.model == null)
            this.model = new CourseCategory();
    }

    public save(): void {
        this.service.save(this.model).subscribe(a=>{
            this.dialog.close(OK);
        });
    }

    public cancel(): void {
        this.dialog.close(Cancel);
    }

   
}
