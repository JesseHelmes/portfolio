import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlowerDetailsPage } from './flower-details.page';

describe('FlowerDetailsPage', () => {
	let component: FlowerDetailsPage;
	let fixture: ComponentFixture<FlowerDetailsPage>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [FlowerDetailsPage],
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(FlowerDetailsPage);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
