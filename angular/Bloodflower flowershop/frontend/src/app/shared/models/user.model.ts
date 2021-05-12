import { Role } from '../enums/role.enum';

export class User {
	id: number;
	username: string;
	access_token?: string;
	roles: Role[];
}
