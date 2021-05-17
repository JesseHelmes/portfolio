import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Role } from 'src/authorization/enums/role.enum';
import { CreateUserDto } from 'src/user/dto/create-user.dto';
import { UpdateUserDto } from 'src/user/dto/update-user.dto';
import { User } from 'src/user/entity/user.entity';
import { Repository } from 'typeorm';

@Injectable()
export class UserService {
	private readonly users = [
		{
			id: 1,
			username: 'Blood Flower',
			password: 'flower',
			roles: [Role.ADMIN],
		},
		{
			id: 2,
			username: 'Bloodshot',
			password: 'blood',
			roles: [Role.ADMIN],
		},
		{
			id: 3,
			username: 'Silverwing',
			password: 'eeee',
			roles: [Role.USER],
		},
	];

	constructor(
		@InjectRepository(User)
		private readonly userRepository: Repository<User>,
	) {}

	public async findByUsername(
		username: string,
	): Promise<User | undefined | any> {
		//return await this.userRepository.findOne(username); //{username}
		return this.users.find((user: User) => user.username === username); //any
	}

	public async findById(id: number): Promise<User> {
		return await this.userRepository.findOne(id);
	}

	public async create(createUserDto: CreateUserDto): Promise<User> {
		let user = new User();
		user = Object.assign(user, createUserDto);

		return await this.userRepository.save(user);
	}

	public async update(
		id: number,
		updateUserDto: UpdateUserDto,
	): Promise<User> {
		let user = await this.findById(id);

		user = Object.assign(user, updateUserDto);

		return await this.userRepository.save(user);
	}
}
