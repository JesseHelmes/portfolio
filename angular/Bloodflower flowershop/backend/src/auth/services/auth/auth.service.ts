import { Injectable } from '@nestjs/common';
import { UserService } from 'src/user/services/user/user.service';
import { JwtService } from '@nestjs/jwt';

@Injectable()
export class AuthService {
	constructor(
		private readonly userService: UserService,
		private jwtService: JwtService,
	) {}

	async validateUser(username: string, password: string): Promise<any> {
		const user = await this.userService.findOne(username);
		if (user && user.password === password) {
			return user;
		}
		return null;
	}

	async login(user: any) {
		const payload = {
			username: user.username,
			userId: user.userId,
			roles: user.roles,
		};

		console.log(user);

		return {
			access_token: this.jwtService.sign(payload),
			roles: user.roles,
			username: user.username,
			id: user.userId,
		};
	}
}
