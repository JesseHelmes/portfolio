import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/core/authentication/authentication.service';
import { NotificationService } from 'src/app/core/services/notification.service';
import { LoginRequest } from '../../request/login.request';

@Component({
	selector: 'app-login',
	templateUrl: './login.page.html',
	styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {
	public form: FormGroup;
	public returnUrl: string;

	constructor(
		private readonly fb: FormBuilder,
		private readonly authenticationService: AuthenticationService,
		private readonly route: ActivatedRoute,
		private readonly router: Router,
		private readonly notificationService: NotificationService
	) {
		//redirect to home if alreaddy logged in
		if (this.authenticationService.currentUserValue) {
			this.router.navigate['/'];
		}
	}

	ngOnInit(): void {
		this.setupForm();
		this.setReturnUrl();
	}

	public setupForm(): void {
		this.form = this.fb.group({
			name: [null, Validators.required],
			password: [null, Validators.required],
		});
	}

	public setReturnUrl(): void {
		this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
	}

	public login(data: LoginRequest): void {
		if (this.form.invalid) {
			return;
		}

		this.authenticationService.login(data.name, data.password).subscribe(
			(success) => {
				this.router
					.navigate([this.returnUrl])
					.then((success: boolean) => {
						if (!success) {
							this.router.navigate(['/']);
						}
					});
			},
			(error) => {
				console.log(error);
				this.notificationService.displayDangerNotification(
					`Gebruikersnaam of wachtwoord is incorrect. <br> ${error.message}`
				);
			}
		);
	}
}
