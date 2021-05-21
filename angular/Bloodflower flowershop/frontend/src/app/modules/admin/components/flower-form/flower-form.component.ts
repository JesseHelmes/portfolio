import {
	Component,
	EventEmitter,
	Input,
	OnChanges,
	OnInit,
	Output,
	SimpleChanges,
} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { FlowerService } from 'src/app/core/services/flower/flower.service';
import { NotificationService } from 'src/app/core/services/notification.service';
import { FlowerModel } from 'src/app/shared/models/flower.model';
import { FlowerRequest } from '../../request/flower.request';

@Component({
	selector: 'admin-flower-form',
	templateUrl: './flower-form.component.html',
	styleUrls: ['./flower-form.component.scss'],
})
export class FlowerFormComponent implements OnInit, OnChanges {
	public form: FormGroup;
	public descriptionMaxChars: number = 255;

	@Input()
	buttonText: string;

	@Input()
	resetForm?: boolean = false;

	@Input()
	flower?: FlowerModel;

	@Output()
	flowerAction: EventEmitter<FlowerRequest> = new EventEmitter<FlowerRequest>();

	constructor(
		private readonly fb: FormBuilder,
		private readonly router: Router,
		private readonly flowerService: FlowerService,
		private readonly notificationService: NotificationService
	) {}

	ngOnChanges(changes: SimpleChanges): void {
		if (this.flower) this.form.patchValue(this.flower);
	}

	ngOnInit(): void {
		this.setupForm();
	}

	public setupForm(): void {
		this.form = this.fb.group({
			name: [null, [Validators.required]],
			secondName: [null, null],
			image: [null, null],
			description: [
				null,
				[Validators.maxLength(this.descriptionMaxChars)],
			],
			price: [null, [Validators.required, Validators.min(1)]],
			blood: [null, null],
		});
	}

	public formAction(flower: FlowerRequest) {
		if (this.form.invalid) {
			return;
		}

		this.flowerAction.emit(flower);

		if (this.resetForm) this.form.reset();
	}

	public deleteFlower() {
		const deleteConfirm = window.confirm(
			`Are you sure that you want to 'root up' ${this.flower.name}${
				this.flower.secondName ? ' aka ' + this.flower.secondName : ''
			}??`
		);

		if (deleteConfirm)
			this.flowerService.deleteFlower(this.flower.id).subscribe(
				(success) => {
					console.log('aww.. you killed the flower!');
					this.router.navigate(['/admin']);
				},
				(error) => {
					//console.log('flower is still alive!');
					this.notificationService.displayDangerNotification(
						`flower is still alive!: ${error.message}`
					);
				}
			);
	}

	public showDescriptionMaxCharsLeft(): number {
		return this.form.get('description').value
			? this.descriptionMaxChars -
					this.form.get('description').value.length
			: this.descriptionMaxChars;
	}
}
