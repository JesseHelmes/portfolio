import { Body, Controller, Get, Post, Param, Patch, Delete, Query, Inject } from '@nestjs/common';
import { REQUEST } from '@nestjs/core';
import { Request } from 'express';
import { PaginationQueryDto } from 'src/common/dto/pagination-query.dto';
import { CoffeesService } from '../service/coffees.service';
import { CreateCoffeeDto } from '../dto/create-coffee.dto';
import { UpdateCoffeeDto } from '../dto/update-coffee.dto';
import { Public } from 'src/common/decorators/public.decorator';
import { ParseIntPipe } from 'src/common/pipes/parse-int.pipe';
import { Protocol } from 'src/common/decorators/protocol.decorator';
import { ApiForbiddenResponse, ApiTags } from '@nestjs/swagger';

@ApiTags('coffees')
@Controller('coffees')
export class CoffeesController {
	constructor(
		private readonly coffeesService: CoffeesService,
		@Inject(REQUEST) private readonly request: Request,
	){
		console.log('CoffeesController created');
	}

	//@Get('flavors')
	@ApiForbiddenResponse({ description: 'Forbidden.' })
	@Public()
	@Get()
	async findAll(@Protocol() protocol: string, @Query() paginationQuery: PaginationQueryDto){
		console.log(protocol);
		//await new Promise(resolve => setTimeout(resolve, 5000));
		//const {limit, offset} = paginationQuery;
		return this.coffeesService.findAll(paginationQuery);
		//return `This action returns all coffees. Limit: ${limit}, offset: ${offset}`;
	}

	@Get(':id')
	findOne(@Param('id', ParseIntPipe) id: number){
		return this.coffeesService.findOne(id);
		//return `This action returns #${id} coffee`;
	}

	@Post()
	create(@Body() createCoffeeDto: CreateCoffeeDto){
		console.log(createCoffeeDto instanceof CreateCoffeeDto);
		return this.coffeesService.create(createCoffeeDto);
		//return `This action creates a coffee`;
	}

	@Patch(':id')
	update(@Param('id') id: string, @Body() updateCoffeeDto: UpdateCoffeeDto){
		return this.coffeesService.update(id, updateCoffeeDto);
		//return `This action updates #${id} coffee`;
	}

	@Delete(':id')
	remove(@Param('id', ParseIntPipe) id: number){
		return this.coffeesService.remove(id);
		//return `This action removes #${id} coffee`;
	}
}
