import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomePage } from './pages/home.page';
import { RouterModule } from '@angular/router';
import { HomeRoutes } from './home.routing';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
	declarations: [HomePage],
	imports: [CommonModule, RouterModule.forChild(HomeRoutes), SharedModule],
})
export class HomeModule {}
