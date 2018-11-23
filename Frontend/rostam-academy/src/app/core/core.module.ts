import { NgModule, InjectionToken } from '@angular/core';
import { AppConfig } from './app-config';
import { environment } from 'src/environments/environment';

export let APP_CONFIG = new InjectionToken<AppConfig>('app.config');
export const APP_DI_CONFIG: AppConfig = {
  apiEndpoint: environment.apiEndpoint
};

@NgModule({
  declarations: [
  ],
  imports: [
  ],
  providers: [
    { provide:APP_CONFIG, useValue:APP_DI_CONFIG }
  ],
  bootstrap: []
})
export class CoreModule { }
