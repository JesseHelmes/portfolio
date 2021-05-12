import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FlowerService } from 'src/app/core/services/flower/flower.service';
import { FlowerModel } from 'src/app/shared/models/flower.model';
//import { tap } from 'rxjs/operators';

@Component({
	selector: 'app-flower-details',
	templateUrl: './flower-details.page.html',
	styleUrls: ['./flower-details.page.scss']
})
export class FlowerDetailsPage implements OnInit {
	public flower: FlowerModel = new FlowerModel;
	public id: number;

	constructor(
		private readonly flowerService: FlowerService,
		private readonly route: ActivatedRoute
		) {}

	ngOnInit(): void {
		this.id = this.route.snapshot.params['id'];
		this.flowerService.getFlower(this.id).subscribe((flower: FlowerModel) => this.flower = flower)
	}

}
