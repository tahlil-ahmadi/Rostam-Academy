import { CourseCategory } from "./course-category.model";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class CourseCategoryService{
    private url = "http://localhost:5000/api/courseCategories";
    
    constructor(private httpClient: HttpClient) {
    }

    getAll(): Observable<Array<CourseCategory>> {
       return this.httpClient.get<Array<CourseCategory>>(this.url);
    }

    delete(id:number): Observable<object> {
        let deleteUrl = `${this.url}/${id}`;
        return this.httpClient.delete(deleteUrl);
    }

    save(model: CourseCategory): Observable<any>{
        return this.httpClient.post(this.url,model);
    }
}