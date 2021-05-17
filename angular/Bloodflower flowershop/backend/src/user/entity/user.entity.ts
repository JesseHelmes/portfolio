import { Exclude } from 'class-transformer';
import { Role } from 'src/authorization/enums/role.enum';
import {
	AfterLoad,
	BeforeInsert,
	BeforeUpdate,
	Column,
	Entity,
	PrimaryGeneratedColumn,
} from 'typeorm';
import * as bcrypt from 'bcrypt';

@Entity()
export class User {
	@PrimaryGeneratedColumn()
	id: number;

	@Column()
	username: string;

	@Exclude()
	@Column()
	password: string;

	@Column({ type: 'json', default: Role.USER })
	roles: Role[];

	@Exclude()
	private tempPassword: string;

	@AfterLoad()
	private loadTempPassword(): void {
		this.tempPassword = this.password;
	}

	@BeforeInsert()
	@BeforeUpdate()
	async hashPassword(): Promise<void> {
		if (this.tempPassword !== this.password) {
			this.password = await bcrypt.hash(this.password, 10);
			this.loadTempPassword();
		}
	}

	public async comparePassword(passwordAttempt: string): Promise<boolean> {
		return await bcrypt.compare(passwordAttempt, this.password);
	}
}
