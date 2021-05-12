import { Injectable } from '@angular/core';

declare const $: any;

@Injectable({ providedIn: 'root' })
export class NotificationService {
	private readonly time = 4000;

	public displayDangerNotification(message: string, time?: number): void {
		this.displayNotification(message, 'danger', time);
	}

	public displaySuccessNotification(message: string, time?: number): void {
		this.displayNotification(message, 'success', time);
	}

	public displayAlertNotification(message: string, time?: number): void {
		this.displayNotification(message, 'alert', time);
	}

	private displayNotification(
		message: string,
		type: string,
		time: number = this.time
	): void {
		$.notify(
			{
				icon: 'add_alert',
				message: message,
			},
			{
				type: type,
				timer: time,
				placement: {
					from: 'top',
					align: 'right',
				},
			}
		);
	}
}
