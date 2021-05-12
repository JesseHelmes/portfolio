import { Module } from '@nestjs/common';
import { FlowerService } from './services/flower/flower.service';
import { FlowerController } from './controllers/flower/flower.controller';
import { Flower } from './entity/flower.entity';
import { TypeOrmModule } from '@nestjs/typeorm';

@Module({
	imports: [TypeOrmModule.forFeature([Flower])],
	providers: [FlowerService],
	controllers: [FlowerController],
})
export class FlowerModule {}
