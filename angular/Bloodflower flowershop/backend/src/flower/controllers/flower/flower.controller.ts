import {
	Body,
	Controller,
	Delete,
	Get,
	Param,
	Patch,
	Post,
	Query,
	UseGuards,
} from '@nestjs/common';
import { JwtAuthGuard } from 'src/auth/guards/jwt-auth.guard';
import { LocalAuthGuard } from 'src/auth/guards/local-auth.guard';
import { Roles } from 'src/authorization/decorators/roles.decorator';
import { Role } from 'src/authorization/enums/role.enum';
import { RolesGuard } from 'src/authorization/guards/roles.guard';
import { PaginationQueryDto } from 'src/common/dto/pagination-query.dto';
import { CreateFlowerDto } from 'src/flower/dto/create-flower.dto';
import { UpdateFlowerDto } from 'src/flower/dto/update-flower.dto';
import { Flower } from 'src/flower/entity/flower.entity';
import { FlowerService } from 'src/flower/services/flower/flower.service';

@Controller('flower')
export class FlowerController {
	constructor(private readonly flowerService: FlowerService) {}

	@Get()
	getFlowers(
		@Query() paginationQueryDto: PaginationQueryDto,
	): Promise<Flower[]> {
		return this.flowerService.getFlowers(paginationQueryDto);
	}

	@Get('search')
	searchFlower(
		@Query('name') name: string,
		@Query() paginationQueryDto: PaginationQueryDto,
	): Promise<Flower[]> {
		return this.flowerService.searchFlowerByName(name, paginationQueryDto);
	}

	@Get(':id')
	getFlower(@Param('id') id: number): Promise<Flower> {
		return this.flowerService.getFlowerById(id);
	}

	@Post()
	@UseGuards(JwtAuthGuard, RolesGuard)
	@Roles(Role.ADMIN)
	createFlower(@Body() createFlowerDto: CreateFlowerDto): Promise<Flower> {
		return this.flowerService.createFlower(createFlowerDto);
	}

	@Patch(':id')
	@UseGuards(JwtAuthGuard, RolesGuard)
	@Roles(Role.ADMIN)
	updateFlower(
		@Param('id') id: number,
		@Body() updateFlowerDto: UpdateFlowerDto,
	): Promise<Flower> {
		return this.flowerService.updateFlower(id, updateFlowerDto);
	}

	@Delete(':id')
	@UseGuards(JwtAuthGuard, RolesGuard)
	@Roles(Role.ADMIN)
	deleteFlower(@Param('id') id: number): Promise<Flower> {
		return this.flowerService.deleteFlower(id);
	}

	@Post('seeding')
	@UseGuards(LocalAuthGuard)
	seedFlowers(@Body('seed') seed: boolean): string {
		return this.flowerService.generateFlowerMockdata(seed);
	}
}
