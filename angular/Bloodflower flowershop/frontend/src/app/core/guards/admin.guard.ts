import { Injectable } from '@angular/core';
import {
	ActivatedRouteSnapshot,
	CanActivate,
	Router,
	RouterStateSnapshot,
	UrlTree,
} from '@angular/router';
import { Observable } from 'rxjs';
import { AuthorizationService } from '../services/authorization/authorization.service';

@Injectable({ providedIn: 'root' })
export class AdminGuard implements CanActivate {
	constructor(
		private router: Router,
		private readonly authorizationService: AuthorizationService
	) {}

	canActivate(
		route: ActivatedRouteSnapshot,
		state: RouterStateSnapshot
	):
		| boolean
		| UrlTree
		| Observable<boolean | UrlTree>
		| Promise<boolean | UrlTree> {
		if (this.authorizationService.isAdmin()) {
			return true;
		}

		this.router.navigate(['/login'], {
			queryParams: { returnUrl: state.url },
		});
		return false;
	}
}
