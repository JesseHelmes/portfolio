import { Injectable } from '@nestjs/common';
import { Role } from 'src/authorization/enums/role.enum';

export type User = any;

@Injectable()
export class UserService {
	private readonly users = [
		{
			userId: 1,
			username: 'Blood Flower',
			password: 'flower',
			roles: [Role.ADMIN],
		},
		{
			userId: 2,
			username: 'Bloodshot',
			password: 'blood',
			roles: [Role.ADMIN],
		},
		{
			userId: 3,
			username: 'Silverwing',
			password: 'eeee',
			roles: [Role.USER],
		},
	];

	constructor() {}

	async findOne(username: string): Promise<User | undefined> {
		return this.users.find((user) => user.username === username);
	}
}
