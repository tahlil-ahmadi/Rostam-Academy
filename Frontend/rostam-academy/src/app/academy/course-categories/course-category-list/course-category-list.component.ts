import { Component } from '@angular/core';
import { CourseCategory } from '../shared/course-category.model';
import { CourseCategoryService } from '../shared/course-category.service';

@Component({
    selector: 'course-category-list',
    templateUrl: './course-category-list.component.html',
})
export class CourseCategoryListComponent {
    private service:CourseCategoryService;
    private courseCategories: Array<CourseCategory>;    
    constructor(service: CourseCategoryService) {
        this.service = service;
        this.service.getAll().subscribe((data:Array<CourseCategory>)=>{
            this.courseCategories = data;
        });
    }


}
