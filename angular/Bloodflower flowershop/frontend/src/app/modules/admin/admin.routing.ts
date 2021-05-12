import { Routes } from '@angular/router';
import { FlowerOverviewPage } from './pages/flower-overview/flower-overview.page';
import { UpdateFlowerPage } from './pages/update-flower/update-flower.page';
import { AddFlowerPage } from './pages/add-flower/add-flower.page';

export const AdminRouting: Routes = [
	{
		path: '',
		children: [
			{
				path: '', //flowers
				component: FlowerOverviewPage,
			},
			{
				path: 'seeding',
				component: AddFlowerPage,
			},
			{
				path: ':id',
				component: UpdateFlowerPage,
			},
		],
	},
];
