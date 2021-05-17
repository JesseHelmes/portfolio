import { IsEnum, IsNotEmpty, IsString } from 'class-validator';
import { Role } from 'src/authorization/enums/role.enum';

export class UpdateUserDto {
	@IsString()
	@IsNotEmpty()
	username: string;

	@IsEnum(Role, { each: true })
	roles: Role[];
}
