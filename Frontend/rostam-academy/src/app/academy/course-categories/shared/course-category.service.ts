import { CourseCategory } from "./course-category.model";
import { Injectable, Inject } from "@angular/core";
import { Observable, of } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { AppConfig } from "src/app/core/app-config";
import { APP_CONFIG } from "src/app/core/core.module";

@Injectable()
export class CourseCategoryService{
    private url = "http://localhost:5550/api/courseCategories";
    
    constructor(private httpClient: HttpClient, 
        @Inject(APP_CONFIG) private config: AppConfig) {
    }

    getAll(): Observable<Array<CourseCategory>> {
       return this.httpClient.get<Array<CourseCategory>>(this.url);
    }

    delete(id:number): Observable<object> {
        let deleteUrl = `${this.url}/${id}`;
        return this.httpClient.delete(deleteUrl);
    }

    save(model: CourseCategory): Observable<any>{
        if (model.id){
            var modifyUrl = `${this.url}/${model.id}`
            return this.httpClient.put(modifyUrl,model);
        }
        else
            return this.httpClient.post(this.url,model);    
    }
}