import { Component } from '@angular/core';
import { DialogRef } from '@progress/kendo-angular-dialog';
import { DialogResponse } from '../../dialog-response.enum';

@Component({
    selector: 'course-category',
    templateUrl: './course-category.component.html',
})
export class CourseCategoryComponent {
   
    constructor(private dialog: DialogRef) {
    }

    public save(): void {
        this.dialog.close(DialogResponse.OK);
    }

    public cancel(): void {
        this.dialog.close(DialogResponse.Cancel);
    }
}
