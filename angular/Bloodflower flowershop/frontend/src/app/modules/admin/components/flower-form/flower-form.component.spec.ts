import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlowerFormComponent } from './flower-form.component';

describe('FlowerFormComponent', () => {
	let component: FlowerFormComponent;
	let fixture: ComponentFixture<FlowerFormComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [FlowerFormComponent],
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(FlowerFormComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
