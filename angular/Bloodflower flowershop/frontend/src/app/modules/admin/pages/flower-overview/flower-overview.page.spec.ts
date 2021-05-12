import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlowerOverviewPage } from './flower-overview.page';

describe('FlowerOverviewPage', () => {
	let component: FlowerOverviewPage;
	let fixture: ComponentFixture<FlowerOverviewPage>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [FlowerOverviewPage],
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(FlowerOverviewPage);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
