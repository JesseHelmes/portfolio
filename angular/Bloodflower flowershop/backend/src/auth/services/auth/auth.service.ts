import { Injectable } from '@nestjs/common';
import { UserService } from 'src/user/services/user/user.service';
import { JwtService } from '@nestjs/jwt';
import { User } from 'src/user/entity/user.entity';

@Injectable()
export class AuthService {
	constructor(
		private readonly userService: UserService,
		private jwtService: JwtService,
	) {}

	async validateUser(username: string, password: string): Promise<any> {
		const user = await this.userService.findByUsername(username);
		if (user && user.password === password) {
			//user.comparePassword(password)
			return user;
		}
		return null;
	}

	async login(user: User) {
		const payload = {
			username: user.username,
			id: user.id,
			roles: user.roles,
		};

		console.log(user);

		return {
			access_token: this.jwtService.sign(payload),
			roles: user.roles,
			username: user.username,
			id: user.id,
		};
	}
}
