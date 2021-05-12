import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { FlowerService } from 'src/app/core/services/flower/flower.service';
import { FlowerModel } from 'src/app/shared/models/flower.model';

@Component({
	selector: 'app-flower-overview',
	templateUrl: './flower-overview.page.html',
	styleUrls: ['./flower-overview.page.scss'],
})
export class FlowerOverviewPage implements OnInit {
	public form: FormGroup;
	public dataRow: string[] = [
		'Name',
		'Second name',
		'Price in bits',
		'Price in blood',
	];
	public flowers: FlowerModel[];

	constructor(
		private readonly flowerService: FlowerService,
		private fb: FormBuilder
	) {}

	ngOnInit(): void {
		this.loadAllFlowers();
		this.setupForm();
	}

	public setupForm(): void {
		this.form = this.fb.group({
			search: ['', null],
		});
	}

	public loadAllFlowers(): void {
		this.flowerService
			.getAllFlowers()
			.subscribe(
				(flowers: FlowerModel[]) =>
					(this.flowers = flowers.sort(this.sortByName))
			);
	}

	public searchFlower(name: string): void {
		if (name) {
			this.flowerService
				.searchFlower(name)
				.subscribe(
					(flowers: FlowerModel[]) => (this.flowers = flowers)
				);
		} else {
			this.loadAllFlowers();
		}

		//delete dwb
		//als er een delete/edit popup komt
		//this.flowers = this.flowers.filter((flower: FlowerModel) => flower.id !== 1);
	}

	public sortByName(flowerA: FlowerModel, flowerB: FlowerModel) {
		if (flowerA.name < flowerB.name) {
			return -1;
		}
		if (flowerA.name > flowerB.name) {
			return 1;
		}
	}
}
