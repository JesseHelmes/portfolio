import { Routes } from '@angular/router';
import { FlowerDetailsPage } from './pages/flower-details/flower-details.page';
import { FlowersPage } from './pages/flowers/flowers.page';

export const FlowersRoutes: Routes = [
	{
		path: '',
		component: FlowersPage,
	},
	{
		path: ':id',
		component: FlowerDetailsPage,
	},
];
