import { Type } from 'class-transformer';
import { IsOptional, IsPositive, IsString, MaxLength } from 'class-validator';

export class UpdateFlowerDto {
	@IsString()
	name: string;

	@IsString()
	@IsOptional()
	secondName: string;

	@IsString()
	@IsOptional()
	@MaxLength(255)
	description: string;

	@IsString()
	@IsOptional()
	image: string;

	@IsPositive()
	@Type(() => Number)
	price: number;

	@IsOptional()
	@IsPositive()
	@Type(() => Number)
	blood: number;
}
