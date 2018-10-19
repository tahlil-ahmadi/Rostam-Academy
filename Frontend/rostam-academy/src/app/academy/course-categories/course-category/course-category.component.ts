import { Component } from '@angular/core';
import { DialogRef } from '@progress/kendo-angular-dialog';
import { OK, Cancel } from '../../dialog-response.enum';
import { CourseCategory } from '../shared/course-category.model';
import { CourseCategoryService } from '../shared/course-category.service';

@Component({
    selector: 'course-category',
    templateUrl: './course-category.component.html',
})
export class CourseCategoryComponent {
   
    private model:CourseCategory;
    constructor(private dialog: DialogRef, private service:CourseCategoryService) {
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
