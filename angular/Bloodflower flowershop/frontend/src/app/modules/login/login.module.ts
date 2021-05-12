import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginPage } from './pages/login/login.page';
import { RouterModule } from '@angular/router';
import { LoginRoutes } from './login.routing';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
	declarations: [LoginPage],
	imports: [
		CommonModule,
		RouterModule.forChild(LoginRoutes),
		ReactiveFormsModule,
	],
})
export class LoginModule {}
