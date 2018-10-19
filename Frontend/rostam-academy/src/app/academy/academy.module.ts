import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule }    from '@angular/common/http';
import { FormsModule } from '@angular/forms'

import { TreeViewModule } from '@progress/kendo-angular-treeview';
import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { DialogsModule } from '@progress/kendo-angular-dialog';
import { GridModule } from '@progress/kendo-angular-grid';

import { CourseCategoryListComponent } from './course-categories/course-category-list/course-category-list.component';
import { CourseCategoryComponent } from './course-categories/course-category/course-category.component';
import { CourseCategoryService } from './course-categories/shared/course-category.service';
import {ClassComponent} from './classes/class.component';
import {ClassService} from './classes/class.service';
import { CourseListComponent } from './courses/course-list/course-list.component'
import { CourseGridService } from './courses/shared/course.service';


// move to a seperate file
const appRoutes: Routes = [
  { path: 'course-category-list', component: CourseCategoryListComponent },
  { path: 'course-category', component: CourseCategoryComponent },
  { path: 'class', component: ClassComponent},
  { path: 'course-list', component: CourseListComponent },
];

@NgModule({
  imports:      [
    BrowserModule,
    TreeViewModule,
    ButtonsModule,
    DialogsModule,
    GridModule,
    HttpClientModule,
    FormsModule,
    GridModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers:    [
    CourseCategoryService,
    ClassService,
    CourseCategoryService,
    CourseGridService
  ],
  declarations: [
    CourseCategoryListComponent,
    CourseCategoryComponent,
    ClassComponent,
    CourseListComponent
  ],
  exports:      [ ],
  bootstrap:    [ ]
})
export class AcademyModule { }
