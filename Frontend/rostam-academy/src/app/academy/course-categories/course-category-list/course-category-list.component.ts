import { Component, OnInit } from '@angular/core';
import { CourseCategory } from '../shared/course-category.model';
import { CourseCategoryService } from '../shared/course-category.service';
import { Observable, of } from 'rxjs';

@Component({
    selector: 'course-category-list',
    templateUrl: './course-category-list.component.html',
})
export class CourseCategoryListComponent implements OnInit {
   
    private courseCategories: Array<CourseCategory>;    
    constructor(private service: CourseCategoryService) { }

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
        debugger;
        this.service.delete(item.id).subscribe((a:any)=>{
            this.loadCourseCategories();
        });
    }

    public edit(item: CourseCategory):void {
        alert("you clicked on item " + item.title);
    }
}
