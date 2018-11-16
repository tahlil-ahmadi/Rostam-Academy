import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { Injectable } from "@angular/core";
import { AuthService } from "./auth.service";

@Injectable()
export class AuthGuard implements CanActivate {

    constructor(private authService: AuthService) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot):  boolean {
        debugger;
        if (this.authService.isUserLoggedIn()){
            return true;
        }
        else{
            this.authService.redirectToSts();
            return false;
        }
    }
}