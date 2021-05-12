import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { NotFoundRouting } from './not-found.routing';
import { NotFoundPage } from './pages/not-found.page';

@NgModule({
	declarations: [NotFoundPage],
	imports: [CommonModule, RouterModule.forChild(NotFoundRouting)],
})
export class NotFoundModule {}
