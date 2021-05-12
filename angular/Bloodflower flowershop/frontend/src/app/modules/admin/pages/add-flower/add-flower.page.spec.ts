import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddFlowerPage } from './add-flower.page';

describe('AddFlowerPage', () => {
	let component: AddFlowerPage;
	let fixture: ComponentFixture<AddFlowerPage>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [AddFlowerPage],
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(AddFlowerPage);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
