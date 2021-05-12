import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { FlowerService } from 'src/app/core/services/flower/flower.service';
import { FlowerModel } from 'src/app/shared/models/flower.model';

@Component({
	selector: 'app-home',
	templateUrl: './home.page.html',
	styleUrls: ['./home.page.scss'],
})
export class HomePage implements OnInit {
	public flowers: Observable<FlowerModel[]>;

	constructor(private readonly flowerService: FlowerService) {}

	ngOnInit(): void {
		this.flowers = this.flowerService.getFlowers(4);
	}
}
