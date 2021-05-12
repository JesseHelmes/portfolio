if (!process.env.NODE_ENV) process.env.NODE_ENV = 'development';

import { NestFactory } from '@nestjs/core';
import { AppModule } from './app.module';
import { ConfigService } from '@nestjs/config';

async function bootstrap() {
	const app = await NestFactory.create(AppModule);
	app.enableCors();

	const configService = app.get(ConfigService);
	await app.listen(configService.get<number>('PORT'));
}
bootstrap();
