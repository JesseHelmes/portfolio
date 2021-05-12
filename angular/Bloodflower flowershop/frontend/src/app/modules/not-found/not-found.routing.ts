import { Routes } from '@angular/router';
import { NotFoundPage } from './pages/not-found.page';

export const NotFoundRouting: Routes = [
	{
		path: '',
		children: [
			{
				path: '',
				component: NotFoundPage,
			},
		],
	},
];
