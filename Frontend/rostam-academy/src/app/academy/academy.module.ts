import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { CourseCategoryListComponent } from './course-categories/course-category-list/course-category-list.component';
import { CourseCategoryComponent } from './course-categories/course-category/course-category.component';

const appRoutes: Routes = [
  { path: 'course-category-list', component: CourseCategoryListComponent },
  { path: 'course-category', component: CourseCategoryComponent },
];

@NgModule({
    imports:      [
      BrowserModule,
      RouterModule.forRoot(appRoutes)
     ],
    providers:    [  ],
    declarations: [
      CourseCategoryListComponent,
      CourseCategoryComponent
     ],
    exports:      [ ],
    bootstrap:    [ ]
  })
export class AcademyModule { }
