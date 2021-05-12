import { Test, TestingModule } from '@nestjs/testing';
import { FlowerService } from './flower.service';

describe('FlowerService', () => {
	let service: FlowerService;

	beforeEach(async () => {
		const module: TestingModule = await Test.createTestingModule({
			providers: [FlowerService],
		}).compile();

		service = module.get<FlowerService>(FlowerService);
	});

	it('should be defined', () => {
		expect(service).toBeDefined();
	});
});
