import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FlowerCardComponent } from './components/flower-card/flower-card.component';
import { RouterModule } from '@angular/router';

@NgModule({
	declarations: [FlowerCardComponent],
	imports: [CommonModule, RouterModule],
	exports: [FlowerCardComponent],
})
export class SharedModule {}
