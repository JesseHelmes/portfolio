import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { FlowerService } from 'src/app/core/services/flower/flower.service';
import { FlowerModel } from 'src/app/shared/models/flower.model';

@Component({
	selector: 'app-flowers',
	templateUrl: './flowers.page.html',
	styleUrls: ['./flowers.page.scss'],
})
export class FlowersPage implements OnInit {
	public flowers: Observable<FlowerModel[]>;
	public form: FormGroup;

	constructor(
		private readonly flowerService: FlowerService,
		private readonly route: ActivatedRoute,
		private router: Router,
		private fb: FormBuilder
	) {}

	ngOnInit(): void {
		this.setupForm();
		this.loadFlowers();
	}

	public setupForm(): void {
		this.form = this.fb.group({
			search: ['', null],
		});
	}

	public loadFlowers(): void {
		const flowerName = this.route.snapshot.queryParamMap.get('name');

		if (flowerName) {
			this.form.get('search').setValue(flowerName);
			this.searchFlower(flowerName); //'silver'
		} else {
			this.flowers = this.flowerService.getAllFlowers();
		}
	}

	public searchFlower(name: string): void {
		if (name) {
			this.flowers = this.flowerService.searchFlower(name);
		} else {
			//when the search field is empty, load new flowers first
			this.flowers = this.flowerService.getAllFlowers();
		}

		this.router.navigate([], {
			relativeTo: this.route,
			queryParams: { name: name ? name : null },
			queryParamsHandling: 'merge', // remove to replace all query params by provided
		});
	}

	//pagination
	public offset: number = 0;
	public limit: number = 5;
	public maxFlowers: number;

	public nextPage(): void {
		if (this.offset < this.maxFlowers) {
			//kleiner dan count van alle flowers
			this.offset = this.offset + this.limit;
			console.log(this.offset);
			this.flowers = this.flowerService.getFlowers(
				this.limit
				//this.offset
			);
		}
	}

	public prevPage(): void {
		if (this.offset > 0) {
			this.offset = this.offset - this.limit;
			console.log(this.offset);
			this.flowers = this.flowerService.getFlowers(
				this.limit
				//this.offset
			);
		}
	}
}
