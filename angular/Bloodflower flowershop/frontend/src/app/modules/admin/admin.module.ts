import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AdminRouting } from './admin.routing';
import { UpdateFlowerPage } from './pages/update-flower/update-flower.page';
import { FlowerOverviewPage } from './pages/flower-overview/flower-overview.page';
import { FlowerFormComponent } from './components/flower-form/flower-form.component';
import { AddFlowerPage } from './pages/add-flower/add-flower.page';

@NgModule({
	declarations: [
		UpdateFlowerPage,
		FlowerOverviewPage,
		FlowerFormComponent,
		AddFlowerPage,
	],
	imports: [
		CommonModule,
		RouterModule.forChild(AdminRouting),
		ReactiveFormsModule,
	],
})
export class AdminModule {}
