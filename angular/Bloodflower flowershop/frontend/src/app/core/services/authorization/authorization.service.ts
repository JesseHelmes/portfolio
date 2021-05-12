import { Injectable } from '@angular/core';
import { Role } from 'src/app/shared/enums/role.enum';
import { AuthenticationService } from '../../authentication/authentication.service';

@Injectable({
	providedIn: 'root',
})
export class AuthorizationService {
	private roles: Role[];

	constructor(private readonly authenticationService: AuthenticationService) {
		this.setupRoles();
	}

	public isAdmin(): boolean {
		return this.hasRole(Role.ADMIN);
	}

	public hasRole(role: Role): boolean {
		this.setupRoles();
		if (this.roles && this.authenticationService.currentUserValue) {
			return this.roles.includes(role);
		}
		return false;
	}

	private setupRoles(): void {
		if (this.authenticationService.currentUserValue) {
			this.roles = this.authenticationService.currentUserValue.roles;
		}
	}
}
