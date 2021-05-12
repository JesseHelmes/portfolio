import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminGuard } from './core/guards/admin.guard';
import { AuthGuard } from './core/guards/auth.guard';

const routes: Routes = [
	{
		path: '',
		loadChildren: () =>
			import('./modules/home/home.module').then((m) => m.HomeModule),
	},
	{
		path: 'login',
		loadChildren: () =>
			import('./modules/login/login.module').then((m) => m.LoginModule),
	},
	{
		path: 'flowers',
		loadChildren: () =>
			import('./modules/flowers/flowers.module').then(
				(m) => m.FlowersModule
			),
	},
	{
		path: 'about-us',
		loadChildren: () =>
			import('./modules/about-us/about-us.module').then(
				(m) => m.AboutUsModule
			),
	},
	{
		path: 'admin',
		canActivate: [AdminGuard],
		loadChildren: () =>
			import('./modules/admin/admin.module').then((m) => m.AdminModule),
	},
	{
		path: '**',
		loadChildren: () =>
			import('./modules/not-found/not-found.module').then(
				(m) => m.NotFoundModule
			),
	},
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule],
})
export class AppRoutingModule {}
