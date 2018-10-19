import { Component, OnInit } from '@angular/core';
import { CourseCategory } from '../shared/course-category.model';
import { CourseCategoryService } from '../shared/course-category.service';
import { Observable, of } from 'rxjs';
import { DialogService, DialogCloseResult } from '@progress/kendo-angular-dialog';
import { CourseCategoryComponent } from '../course-category/course-category.component';
import { OK } from '../../dialog-response.enum';

@Component({
    selector: 'course-category-list',
    templateUrl: './course-category-list.component.html',
})
export class CourseCategoryListComponent implements OnInit {
   
    private courseCategories: Array<CourseCategory>;    
    constructor(private service: CourseCategoryService,
                private dialogService: DialogService) {
    }

    ngOnInit(): void {
        this.loadCourseCategories();
    }

    private loadCourseCategories() {
        this.service.getAll().subscribe((data: Array<CourseCategory>) => {
            this.courseCategories = data;
        });
    }

    public fetchChildren(node: any): Observable<any[]> {
        return of(node.childCategories);
    }

    public hasChildren(node: any): boolean {
        return node.childCategories && node.childCategories.length > 0;
    }

    public delete(item: CourseCategory):void {
        this.service.delete(item.id).subscribe((a:any)=>{
            this.loadCourseCategories();
        });
    }

    public edit(item: CourseCategory):void {
        alert("you clicked on item " + item.title);
    }

    public addRoot():void {
        const dialogRef = this.dialogService.open({
            title: 'Add Root Course Category',
            content: CourseCategoryComponent
        });

        dialogRef.result.subscribe((result:any)=>{
            if (result == OK){
                this.loadCourseCategories();
            }
        });
    }

    public addChild(item: CourseCategory) : void {
        alert(item.id);
    }
}
