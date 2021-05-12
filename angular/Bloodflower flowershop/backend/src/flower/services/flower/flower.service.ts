import { Injectable, NotFoundException } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Like, Repository } from 'typeorm';
import { PaginationQueryDto } from 'src/common/dto/pagination-query.dto';
import { Flower } from 'src/flower/entity/flower.entity';
import { CreateFlowerDto } from 'src/flower/dto/create-flower.dto';
import { UpdateFlowerDto } from 'src/flower/dto/update-flower.dto';
import { flowerData } from 'src/flower/flower-mockdata';

@Injectable()
export class FlowerService {
	constructor(
		@InjectRepository(Flower)
		private readonly flowerRepository: Repository<Flower>,
	) {}

	public getFlowers(
		paginationQueryDto?: PaginationQueryDto,
	): Promise<Flower[]> {
		return this.flowerRepository.find({
			where: {},
			take: paginationQueryDto.limit,
			skip: paginationQueryDto.offset,
			order: { id: 'DESC' },
		});
	}

	public searchFlowerByName(
		name: string,
		paginationQueryDto?: PaginationQueryDto,
	): Promise<Flower[]> {
		return this.flowerRepository.find({
			where: [
				{
					name: Like(`${name}%`),
				},
				{
					secondName: Like(`${name}%`),
				},
			],
			take: paginationQueryDto.limit,
			skip: paginationQueryDto.offset,
		});
	}

	public async getFlowerById(id: number): Promise<Flower> {
		const flower = await this.flowerRepository.findOne(id);
		if (!flower) {
			throw new NotFoundException('Flower not found');
		}
		return flower;
	}

	public async createFlower(
		createFlowerDto: CreateFlowerDto,
	): Promise<Flower> {
		let flower = new Flower();
		flower = Object.assign(flower, createFlowerDto);
		return await this.flowerRepository.save(flower);
	}

	public async updateFlower(
		id: number,
		updateFlowerDto: UpdateFlowerDto,
	): Promise<Flower> {
		let flower = await this.getFlowerById(id);
		flower = Object.assign(flower, updateFlowerDto);
		return this.flowerRepository.save(flower);
	}

	public async deleteFlower(id: number): Promise<Flower> {
		const flower = await this.getFlowerById(id);
		return this.flowerRepository.remove(flower);
	}

	public generateFlowerMockdata(seed: boolean = false): string {
		let msg = 'No flowers have been seeded..';

		if (seed) {
			for (let mockFlower in flowerData) {
				let createFlowerDto = new CreateFlowerDto();
				createFlowerDto = Object.assign(createFlowerDto, mockFlower);
				this.createFlower(createFlowerDto);
			}

			msg = 'Flowers have been seeded!';
		}

		return msg;
	}
}
