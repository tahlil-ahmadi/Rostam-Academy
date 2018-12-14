export class CourseCategory{
    public id:number;
    public title:string;
    public childCategories: Array<CourseCategory>;
}