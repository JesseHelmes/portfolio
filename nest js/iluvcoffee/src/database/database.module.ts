import { DynamicModule, Module } from '@nestjs/common';
import { ConnectionOptions, createConnection } from 'typeorm';

@Module({
	// Initial attempt at creating "CONNECTION" provider, and utilizing useValue for values */
	/*providers: [{
		provide: 'CONNECTION',
		useValue: createConnection({
			type: 'mariadb',
			host: 'localhost',
			port: 3306,
		}),
	},
],*/
})

// Improved Dynamic Module way of creating CONNECTION provider
export class DatabaseModule {
	static register(options: ConnectionOptions): DynamicModule{
		return {
			module: DatabaseModule,
			providers: [
				{
					provide: 'CONNECTION',
					useValue: createConnection(options),
				}
			]
		}
	}
}
