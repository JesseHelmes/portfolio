import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlowersPage } from './flowers.page';

describe('FlowersPage', () => {
	let component: FlowersPage;
	let fixture: ComponentFixture<FlowersPage>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [FlowersPage],
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(FlowersPage);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
