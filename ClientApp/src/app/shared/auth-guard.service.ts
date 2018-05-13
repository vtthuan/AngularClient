import { Injectable } from '@angular/core';
import { Router, CanActivate, RouterStateSnapshot, ActivatedRouteSnapshot } from "@angular/router";
import { UserService } from "./services/user.service";
import { Observable } from "rxjs/Rx";

@Injectable()
export class AuthGuardService implements CanActivate {

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | Observable<boolean> | Promise<boolean> {
    if (!this.user.isLoggedIn()) {
      this.router.navigate(['/account/login']);
      return false;
    }

    return true;
  }

  constructor(private user: UserService, private router: Router) { }
}
