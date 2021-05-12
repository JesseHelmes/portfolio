import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateFlowerPage } from './update-flower.page';

describe('UpdateFlowerPage', () => {
	let component: UpdateFlowerPage;
	let fixture: ComponentFixture<UpdateFlowerPage>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [UpdateFlowerPage],
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(UpdateFlowerPage);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
