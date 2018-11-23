import { HttpInterceptor, HttpRequest, HttpHandler } from "@angular/common/http";
import { AuthService } from "./auth.service";
import { Injectable } from "@angular/core";

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

    constructor(private auth: AuthService) { }

    intercept(req: HttpRequest<any>, next: HttpHandler) {
        const token = this.auth.getCurrentToken();
        const authReq = req.clone({
            headers: req.headers.set('Authorization', token)
        });
        return next.handle(authReq);
    }
}