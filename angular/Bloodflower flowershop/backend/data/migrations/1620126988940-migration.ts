import {MigrationInterface, QueryRunner} from "typeorm";

export class migration1620126988940 implements MigrationInterface {
    name = 'migration1620126988940'

    public async up(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query("CREATE TABLE `flower` (`id` int NOT NULL AUTO_INCREMENT, `name` varchar(255) NOT NULL, `description` varchar(255) NULL, `image` varchar(255) NULL, `price` int NOT NULL, `blood` int NULL, PRIMARY KEY (`id`)) ENGINE=InnoDB");
    }

    public async down(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query("DROP TABLE `flower`");
    }

}
