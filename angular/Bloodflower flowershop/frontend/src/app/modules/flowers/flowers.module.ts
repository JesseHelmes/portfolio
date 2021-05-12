import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FlowerDetailsPage } from './pages/flower-details/flower-details.page';
import { FlowersPage } from './pages/flowers/flowers.page';
import { RouterModule } from '@angular/router';
import { FlowersRoutes } from './flowers.routing';
import { SharedModule } from 'src/app/shared/shared.module';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
	declarations: [FlowersPage, FlowerDetailsPage],
	imports: [
		CommonModule,
		RouterModule.forChild(FlowersRoutes),
		SharedModule,
		ReactiveFormsModule,
	],
})
export class FlowersModule {}
