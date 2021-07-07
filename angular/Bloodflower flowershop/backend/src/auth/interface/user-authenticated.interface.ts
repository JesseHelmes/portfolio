import { Role } from 'src/authorization/enums/role.enum';

export interface IUserAuthenticated {
	id: number;
	username: string;
	roles: Role[];
	iat: number;
	exp: number;
}
