import { Column, Entity, PrimaryGeneratedColumn } from 'typeorm';

@Entity()
export class Flower{
	@PrimaryGeneratedColumn()
	id: number;

	@Column()
	name: string;

	@Column({nullable: true})
	secondName: string

	@Column({nullable: true})
	description: string;

	@Column({nullable: true})
	image: string;

	@Column()
	price: number;

	@Column({nullable: true})
	blood: number;
}