import { Column, Entity, JoinTable, PrimaryGeneratedColumn, ManyToMany } from "typeorm";
import { Flavor } from "./flavor.entity";

@Entity() //sql table === 'coffee'
export class Coffee{
	@PrimaryGeneratedColumn()
	id: number;

	@Column()
	name: string;

	@Column({nullable: true})
	description: string;

	@Column({default: 0})
	recommendations: number;

	@Column()
	brand: string;

	//@Column('json', {nullable: true})
	@JoinTable()
	@ManyToMany(type => Flavor, flavor => flavor.coffees,{
			cascade: true,//['insert']
		})
	flavors: Flavor[];
}