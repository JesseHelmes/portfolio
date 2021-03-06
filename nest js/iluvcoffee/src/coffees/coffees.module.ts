import { Injectable, Module, Scope } from '@nestjs/common';
import { ConfigModule } from '@nestjs/config';
import { TypeOrmModule } from '@nestjs/typeorm';
import { Event } from 'src/events/entities/event.entity';
//import { Connection } from 'typeorm';
//import { COFFEE_BRANDS } from './coffees.constant';
import { CoffeesController } from './controllers/coffees.controller';
import { CoffeesService } from './service/coffees.service';
import coffeesConfig from './config/coffees.config';
import { Coffee } from './entities/coffee.entity';
import { Flavor } from './entities/flavor.entity';

//class ConfigService {}
//class DevelopmentConfigService {}
//class ProductionConfigService {}

@Injectable()
export class CoffeeBrandsFactory{
	create(){
		return ['buddy brew', 'nescafe'];
	}
}

@Module({ imports: [TypeOrmModule.forFeature([Coffee, Flavor, Event]), // 👈 Adding Coffee Entity here to TypeOrmModule.forFeature
	ConfigModule.forFeature(coffeesConfig)],
	controllers: [CoffeesController],
	providers: [CoffeesService,
		CoffeeBrandsFactory,
		//{provide: ConfigService, useClass: process.env.NODE_ENV === 'development' ? DevelopmentConfigService : ProductionConfigService},
		{provide: 'COFFEE_BRANDS', useFactory: () => ['buddy brew', 'nescafe'], scope: Scope.TRANSIENT} // 👈
		//{provide: COFFEE_BRANDS, useFactory: (brandsFactory: CoffeeBrandsFactory) => brandsFactory.create(), inject: [CoffeeBrandsFactory]}],
		/*{
			provide: 'COFFEE_BRANDS',
			// Note "async" here, and Promise/Async event inside the Factory function 
			// Could be a database connection / API call / etc
			// In our case we're just "mocking" this type of event with a Promise
			useFactory: async (connection: Connection): Promise<string[]> => {
			//const coffeeBrands = await connection.query('SELECT * ...');
			const coffeeBrands = await Promise.resolve(['buddy brew', 'nescafe']);
			console.log('[!] Async factory');
			return coffeeBrands;
		}, inject: [Connection],
	},*/
	],
	exports: [CoffeesService]
})
export class CoffeesModule { }
