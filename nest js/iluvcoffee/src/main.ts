if (!process.env.NODE_ENV) process.env.NODE_ENV = 'development';

import { ValidationPipe } from '@nestjs/common';
import { NestFactory } from '@nestjs/core';
import { AppModule } from './app.module';
import { HttpExceptionFilter } from './common/filters/http-exception.filter';
import { TimeoutInterceptor } from './common/interceptors/timeout.interceptor';
import { WrapResponseInterceptor } from './common/interceptors/wrap-response.interceptor';
//import { ApiKeyGuard } from './common/guards/api-key.guard';
import { DocumentBuilder, SwaggerModule } from '@nestjs/swagger';
import { ConfigService } from '@nestjs/config';

async function bootstrap() {
  const app = await NestFactory.create(AppModule);
  app.enableCors();//voor 'Access-Control-Allow-Origin'
  app.useGlobalPipes(new ValidationPipe({
	  whitelist: true,
	  transform: true,
	  forbidNonWhitelisted: true,//verkomt dat parameters die niet bestaan verzonden worden
	  transformOptions: {
		  enableImplicitConversion: true,
	  }
	}));
	app.useGlobalInterceptors(
		new WrapResponseInterceptor(), 
		new TimeoutInterceptor()
		);
	app.useGlobalFilters(new HttpExceptionFilter());
	//app.useGlobalGuards(new ApiKeyGuard());

	const options = new DocumentBuilder()
		.setTitle('iluvcoffee')
		.setDescription('coffee application')
		.setVersion('1.0')
		.build();
	const document = SwaggerModule.createDocument(app, options);
	SwaggerModule.setup('api', app, document);

	const configService = app.get(ConfigService);
	await app.listen(configService.get<number>('PORT'));
}
bootstrap();
