import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FlowerService } from 'src/app/core/services/flower/flower.service';
import { NotificationService } from 'src/app/core/services/notification.service';
import { FlowerModel } from 'src/app/shared/models/flower.model';
import { FlowerRequest } from '../../request/flower.request';

@Component({
	selector: 'app-update-flower',
	templateUrl: './update-flower.page.html',
	styleUrls: ['./update-flower.page.scss'],
})
export class UpdateFlowerPage implements OnInit {
	public flowerId: number;
	public flower: FlowerModel;

	constructor(
		private flowerService: FlowerService,
		private readonly route: ActivatedRoute,
		private notificationService: NotificationService
	) {}

	ngOnInit(): void {
		this.flowerId = this.route.snapshot.params['id'];

		if (this.flowerId)
			this.flowerService
				.getFlower(this.flowerId)
				.subscribe((flower: FlowerModel) => (this.flower = flower));
	}

	public updateFlower(data: FlowerRequest): void {
		this.flowerService.updateFlower(this.flowerId, data).subscribe(
			(success) => {
				//console.log('flower have been saved, yay!');
				this.notificationService.displaySuccessNotification(
					'flower have been saved, yay!'
				);
			},
			(error) => {
				//console.log('flower failed!');
				this.notificationService.displayDangerNotification(
					`flower failed!: ${error.message}`
				);
			}
		);
	}
}
