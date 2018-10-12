export class CourseCategory{
    public id:number;
    public title:string;
    public childCategories: Array<CourseCategory>;

    // constructor(id:number, title:string){
    //     this.id = id;
    //     this.title = title;
    // }
}