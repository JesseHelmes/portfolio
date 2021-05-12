import { Component, Input, OnInit } from '@angular/core';
import { FlowerModel } from '../../models/flower.model';

@Component({
	selector: 'flower-card',
	templateUrl: './flower-card.component.html',
	styleUrls: ['./flower-card.component.scss'],
})
export class FlowerCardComponent implements OnInit {
	@Input()
	flower: FlowerModel;

	constructor() {}

	ngOnInit(): void {}
}
