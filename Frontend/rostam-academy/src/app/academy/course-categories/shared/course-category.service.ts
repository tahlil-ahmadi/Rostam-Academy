import { CourseCategory } from './course-category.model';
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { BaseHttpService } from "@core/base-http.service";

@Injectable()
export class CourseCategoryService extends BaseHttpService<CourseCategory> {
    constructor(httpClient: HttpClient) {
        super(httpClient, "CourseCategories")
    }

    save(model: CourseCategory): Observable<any> {
        if (model.id) {
            return this.put(model, model.id);
        }
        else
            return this.post(model);
    }
}