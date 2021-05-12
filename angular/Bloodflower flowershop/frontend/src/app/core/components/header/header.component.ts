import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/shared/models/user.model';
import { AuthenticationService } from '../../authentication/authentication.service';
import { AuthorizationService } from '../../services/authorization/authorization.service';

@Component({
	selector: 'app-header',
	templateUrl: './header.component.html',
	styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
	public currentUser: User;

	constructor(
		private authenticationService: AuthenticationService,
		private readonly authorizationService: AuthorizationService
	) {
		this.authenticationService.currentUser.subscribe(
			(user: User) => (this.currentUser = user)
		);
	}

	ngOnInit(): void {}

	public logout(): void {
		this.authenticationService.logout();
	}

	public isLoggedIn(): boolean {
		return Boolean(this.currentUser);
	}

	public isAdmin(): boolean {
		return this.authorizationService.isAdmin();
	}

	public getUsername(): string {
		return this.currentUser ? this.currentUser.username : '';
	}
}
