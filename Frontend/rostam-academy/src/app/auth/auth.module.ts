import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule }    from '@angular/common/http';
import { FormsModule } from '@angular/forms'
import { AuthService } from './shared/auth.service';
import { AuthGuard } from './shared/auth-guard.service';
import { AuthCallbackComponent } from './auth-callback/auth-callback.component';

const authRoutes: Routes = [
  { path: 'auth-callback', component: AuthCallbackComponent },
];

@NgModule({
    imports:      [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      RouterModule.forChild(authRoutes)
     ],
    providers:    [ 
      AuthService,
      AuthGuard,
    ],
    declarations: [
      AuthCallbackComponent
     ],
    entryComponents:[],
    exports:      [ ],
    bootstrap:    [ ]
  })
export class AuthModule { }
