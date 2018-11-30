import { BrowserModule } from '@angular/platform-browser';
import { NgModule, InjectionToken } from '@angular/core';
import {AcademyModule} from './academy/academy.module';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { MenuBarComponent } from './menu-bar/menu-bar.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GridModule } from '@progress/kendo-angular-grid';

import { TEST_INJECTION_TOKEN } from './shared';



@NgModule({
  declarations: [
    AppComponent,
    MenuBarComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    AcademyModule,
    BrowserAnimationsModule
  ],
  providers: [
    {provide:TEST_INJECTION_TOKEN, useValue:"202030"}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
