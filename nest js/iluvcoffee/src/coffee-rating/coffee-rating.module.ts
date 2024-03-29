import { Module } from '@nestjs/common';
import { CoffeesModule } from 'src/coffees/coffees.module';
import { DatabaseModule } from 'src/database/database.module';
import { CoffeeRatingService } from './service/coffee-rating.service';

@Module({
	imports: [
		DatabaseModule.register({
			type: 'mariadb',
			host: 'localhost',
			password: '',
			port: 3306,
		}),
		CoffeesModule],
	providers: [CoffeeRatingService]
})
export class CoffeeRatingModule {}
