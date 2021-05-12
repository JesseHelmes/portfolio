import { Injectable } from '@angular/core';
import {
	HttpRequest,
	HttpHandler,
	HttpEvent,
	HttpInterceptor,
} from '@angular/common/http';
import { Observable } from 'rxjs';

import { AuthenticationService } from '../authentication/authentication.service';
import { environment } from 'src/environments/environment';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
	constructor(private authenticationService: AuthenticationService) {}

	intercept(
		request: HttpRequest<any>,
		next: HttpHandler
	): Observable<HttpEvent<any>> {
		const currentFlowerUser = this.authenticationService.currentUserValue;
		const isLoggedIn = currentFlowerUser && currentFlowerUser.access_token;
		const isApiUrl = request.url.startsWith(environment.apiUrl);
		if (isApiUrl && isLoggedIn) {
			request = request.clone({
				setHeaders: {
					Authorization: `Bearer ${currentFlowerUser.access_token}`,
				},
			});
		}

		return next.handle(request);
	}
}
