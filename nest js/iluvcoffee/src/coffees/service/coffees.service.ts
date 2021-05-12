import { NotFoundException, Injectable, Inject, Scope } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { PaginationQueryDto } from 'src/common/dto/pagination-query.dto';
import { Connection, Repository } from 'typeorm';
import { CreateCoffeeDto } from '../dto/create-coffee.dto';
import { UpdateCoffeeDto } from '../dto/update-coffee.dto';
import { Coffee } from '../entities/coffee.entity';
import { Flavor } from '../entities/flavor.entity';
import { Event } from 'src/events/entities/event.entity';
import { COFFEE_BRANDS } from '../coffees.constant';
import { ConfigService, ConfigType } from '@nestjs/config';
import coffeesConfig from '../config/coffees.config';

// Scope DEFAULT - This is assumed when NO Scope is entered like so: @Injectable() */
@Injectable({scope: Scope.DEFAULT})
export class CoffeesService {
	/*private coffees: Coffee[] = [{
		id: 1,
		name: 'Shipwreck Roast',
		brand: 'Buddy Brew',
		flavors: ['chocolate', 'vanilla'],
		},
	];*/

	/*
	{
		"name": "Cookie",
		"brand": "The cookie brand",
		"flavors": ["cookie", "chocolate chip", "chocolate", "vanilla"]
	}
	*/


	constructor(
		@InjectRepository(Coffee)
		private readonly coffeeRepository: Repository<Coffee>,
		@InjectRepository(Flavor)
		private readonly flavorRepository: Repository<Flavor>,
		private readonly connection: Connection,
		private readonly configService: ConfigService,
		@Inject(COFFEE_BRANDS) coffeeBrands: string[],
		@Inject(coffeesConfig.KEY)
		private coffeesConfiguration: ConfigType<typeof coffeesConfig>, 
	){
		console.log('CoffeeService instantiated');
		//const databaseHost = this.configService.get('database.host', 'localhost');
		//console.log(databaseHost);
		//const coffeesConfig = this.configService.get('coffees.foo');
		console.log(coffeesConfiguration.foo);
	}

	findAll(paginationQuery: PaginationQueryDto){
		const {limit, offset} = paginationQuery;
		return this.coffeeRepository.find({
			relations: ['flavors'],
			skip: offset,
			take: limit
		});
	}

	async findOne(id: number){
		const coffee = await this.coffeeRepository.findOne(id, {
			relations: ['flavors']
		});
		if(!coffee){
			throw new NotFoundException(`Coffee #${id} not found`);
		}
		return coffee;
	}

	async create(createCoffeeDto: CreateCoffeeDto){
		const flavors = await Promise.all(
			createCoffeeDto.flavors.map(name => this.preloadFlavorByName(name)),
		);
		
		const coffee = this.coffeeRepository.create({
			...createCoffeeDto,
			flavors,
		});
		return this.coffeeRepository.save(coffee);
	}

	async update(id: string, updateCoffeeDto: UpdateCoffeeDto){
		const flavors = updateCoffeeDto.flavors &&
		(await Promise.all(
			updateCoffeeDto.flavors.map(name => this.preloadFlavorByName(name)),
		));

		const coffee = await this.coffeeRepository.preload({
			id: +id,
			...updateCoffeeDto,
			flavors,
		});
		if(!coffee){
			throw new NotFoundException(`Coffee #${id} not found`);
		}
		return this.coffeeRepository.save(coffee);
	}

	async remove(id: number){
		const coffee = await this.findOne(id);
		return this.coffeeRepository.remove(coffee);
	}

	async recommendCoffee(coffee: Coffee){
		const queryRunner = this.connection.createQueryRunner();

		await queryRunner.connect();
		await queryRunner.startTransaction();
		try{
			coffee.recommendations++;

			const recommendEvent = new Event();
			recommendEvent.name = 'recommend_coffee';
			recommendEvent.type = 'coffee';
			recommendEvent.payload = {coffeeId: coffee.id};

			await queryRunner.manager.save(coffee);
			await queryRunner.manager.save(recommendEvent);

			await queryRunner.commitTransaction();
		} catch(err){
			await queryRunner.rollbackTransaction();
		}finally{
			await queryRunner.release();
		}
	}

	private async preloadFlavorByName(name: string): Promise<Flavor>{
		const existingFlavor = await this.flavorRepository.findOne({ name });
		if(existingFlavor){
			return existingFlavor;
		}
		return this.flavorRepository.create({ name });
	}
}