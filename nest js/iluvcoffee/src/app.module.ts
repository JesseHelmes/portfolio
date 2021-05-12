import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { CoffeesModule } from './coffees/coffees.module';
import { CoffeeRatingModule } from './coffee-rating/coffee-rating.module';
import { DatabaseModule } from './database/database.module';
import { ConfigModule } from '@nestjs/config';
import { CommonModule } from './common/common.module';
//import * as Joi from '@hapi/joi';
import appConfig from './config/app.config';

@Module({
  imports: [
	ConfigModule.forRoot({
		/*validationSchema: Joi.object({
		  DATABASE_HOST: Joi.required(),
		  DATABASE_PORT: Joi.number().default(3306),
		}),*/
		//load: [appConfig]
		envFilePath: [
			'.env.production',
			'.env.acceptance',
			'.env.staging',
			'.env.development',
			'.env.local',
		  ],
		  isGlobal: true,
		  ignoreEnvFile: process.env.NODE_ENV !== 'development',
	  }),
	TypeOrmModule.forRootAsync({
		useFactory: () => ({
		  type: 'mariadb',
		  host: process.env.DATABASE_HOST,
		  port: +process.env.DATABASE_PORT,
		  username: process.env.DATABASE_USER,
		  password: process.env.DATABASE_PASSWORD,
		  database: process.env.DATABASE_NAME,//iluvcoffee
		  autoLoadEntities: true, // models will be loaded automatically (you don't have to explicitly specify the entities: [] array)
		  synchronize: true, // your entities will be synced with the database (ORM will map entity definitions to corresponding SQL tabled), every time you run the application (recommended: disable in the production)
		}),
	}),
	CoffeesModule, CoffeeRatingModule, DatabaseModule, CommonModule],
  controllers: [AppController],
  providers: [AppService],
})
export class AppModule {}
