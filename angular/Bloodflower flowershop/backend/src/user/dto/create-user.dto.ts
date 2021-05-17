import { IsEnum, IsNotEmpty, IsString } from 'class-validator';
import { Role } from 'src/authorization/enums/role.enum';

export class CreateUserDto {
	@IsString()
	@IsNotEmpty()
	username: string;

	@IsString()
	@IsNotEmpty()
	password: string;

	@IsEnum(Role, { each: true })
	roles: Role[];
}
