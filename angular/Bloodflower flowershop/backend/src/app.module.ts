import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { ConfigModule, ConfigService } from '@nestjs/config';
import { FlowerModule } from './flower/flower.module';
import { AuthModule } from './auth/auth.module';
import { UserModule } from './user/user.module';

@Module({
	imports: [
		ConfigModule.forRoot({
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
			imports: [ConfigModule],
			useFactory: (configService: ConfigService) => ({
			type: 'mariadb',
			host: configService.get<string>('DB_HOST'),
			port: +configService.get<number>('DB_PORT'),
			username: configService.get<string>('DB_USERNAME'),
			password: configService.get<string>('DB_PASSWORD'),
			database: configService.get<string>('DB_DATABASE'),
			entities: [__dirname + '/**/entity/*.entity{.ts,.js}'],
			}),
			inject: [ConfigService],
		}),
	FlowerModule,
	AuthModule,
	UserModule],
	controllers: [AppController],
	providers: [AppService],
})
export class AppModule {}
