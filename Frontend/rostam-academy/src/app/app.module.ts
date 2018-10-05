import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {AcademyModule} from './academy/academy.module';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    AcademyModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
