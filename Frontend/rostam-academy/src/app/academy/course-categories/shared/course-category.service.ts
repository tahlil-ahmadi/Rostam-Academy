import { CourseCategory } from "./course-category.model";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class CourseCategoryService{
    
    constructor(private httpClient: HttpClient) {
    }

    getAll(): Observable<Array<CourseCategory>> {
       var url = "http://localhost:5000/api/courseCategories";
       return this.httpClient.get<Array<CourseCategory>>(url);
    }
}