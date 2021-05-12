import {MigrationInterface, QueryRunner} from "typeorm";

export class migration1620222137235 implements MigrationInterface {
    name = 'migration1620222137235'

    public async up(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query("ALTER TABLE `flower` ADD `secondName` varchar(255) NULL");
    }

    public async down(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query("ALTER TABLE `flower` DROP COLUMN `secondName`");
    }

}
