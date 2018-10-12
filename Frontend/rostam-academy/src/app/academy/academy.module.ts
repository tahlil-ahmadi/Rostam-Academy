import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule }    from '@angular/common/http';

import { TreeViewModule } from '@progress/kendo-angular-treeview';
import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { DialogsModule } from '@progress/kendo-angular-dialog';

import { CourseCategoryListComponent } from './course-categories/course-category-list/course-category-list.component';
import { CourseCategoryComponent } from './course-categories/course-category/course-category.component';
import { CourseCategoryService } from './course-categories/shared/course-category.service';

const appRoutes: Routes = [
  { path: 'course-category-list', component: CourseCategoryListComponent },
  { path: 'course-category', component: CourseCategoryComponent },
];

@NgModule({
    imports:      [
      BrowserModule,
      TreeViewModule,
      ButtonsModule,
      DialogsModule,
      HttpClientModule,
      RouterModule.forRoot(appRoutes)
     ],
    providers:    [ CourseCategoryService ],
    declarations: [
      CourseCategoryListComponent,
      CourseCategoryComponent
     ],
    exports:      [ ],
    bootstrap:    [ ]
  })
export class AcademyModule { }
