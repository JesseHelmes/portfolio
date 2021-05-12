import { Component, OnInit } from '@angular/core';
import { FlowerService } from 'src/app/core/services/flower/flower.service';
import { NotificationService } from 'src/app/core/services/notification.service';
import { FlowerRequest } from '../../request/flower.request';

@Component({
	selector: 'app-add-flower',
	templateUrl: './add-flower.page.html',
	styleUrls: ['./add-flower.page.scss'],
})
export class AddFlowerPage implements OnInit {
	constructor(
		private flowerService: FlowerService,
		private notificationService: NotificationService
	) {}

	ngOnInit(): void {}

	public addFlower(data: FlowerRequest): void {
		this.flowerService.createFlower(data).subscribe(
			(success) => {
				//console.log('flower have been seeded!');
				this.notificationService.displaySuccessNotification(
					'flower have been seeded!'
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
