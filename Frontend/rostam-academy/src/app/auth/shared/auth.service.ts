import { Injectable } from "@angular/core";
import { UserManagerSettings, UserManager, User } from "oidc-client"

@Injectable()
export class AuthService {

    private userManager = new UserManager(this.getSettings());
    private user:User;

    isUserLoggedIn() : boolean{
        //TODO: also check for token expiration
        return this.user != null;
    }
    redirectToSts() {
        this.userManager.signinRedirect();
    }

    redirectCallback() {
        this.userManager.signinRedirectCallback().then(user=>{
            this.user = user;
        })
    }

    getSettings() : UserManagerSettings{
        return {
            authority: 'http://localhost:5000/',
            client_id: 'academy',
            redirect_uri: 'http://localhost:4200/auth-callback',
            post_logout_redirect_uri: 'http://localhost:4200/',
            response_type: "id_token token",
            scope: "openid profile",
            filterProtocolClaims: true,
            loadUserInfo: true,
            automaticSilentRenew: true,
            silent_redirect_uri: 'http://localhost:4200/silent-refresh.html'
          };
    }
}