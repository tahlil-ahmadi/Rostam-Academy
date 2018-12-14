import { CourseCategoryComponent } from "../course-category/course-category.component";
import { CourseCategoryListComponent } from "./course-category-list.component";
import { CourseCategory } from "../shared/course-category.model";
import { of } from "rxjs";

describe('CourseCategoryList component', () => {

    it('should load course categories on init', () => {
        const list = new Array<CourseCategory>();
        list.push(<CourseCategory>{id:1, title:"X"});
        const service = jasmine.createSpyObj(['getAll']);
        service.getAll.and.returnValue(of(list));
        const sut = new CourseCategoryListComponent(service, null);
        
        sut.ngOnInit();
        
        expect(sut.courseCategories).toBe(list);
    })
});