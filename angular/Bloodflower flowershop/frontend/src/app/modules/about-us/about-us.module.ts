import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AboutUsPage } from './pages/about-us/about-us.page';
import { RouterModule } from '@angular/router';
import { AboutUsRouting } from './about-us.routing';

@NgModule({
	declarations: [AboutUsPage],
	imports: [CommonModule, RouterModule.forChild(AboutUsRouting)],
})
export class AboutUsModule {}
