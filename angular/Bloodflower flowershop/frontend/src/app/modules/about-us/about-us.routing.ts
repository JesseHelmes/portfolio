import { Routes } from '@angular/router';
import { AboutUsPage } from './pages/about-us/about-us.page';

export const AboutUsRouting: Routes = [
	{
		path: '',
		children: [
			{
				path: '',
				component: AboutUsPage,
			},
		],
	},
];
