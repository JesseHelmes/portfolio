import { MigrationInterface, QueryRunner } from 'typeorm';

export class flowerSeeder1620983656359 implements MigrationInterface {
	name = 'flowerSeeder1620983656359';

	//https://www.webtoolkitonline.com/sql-minifier.html
	public async up(queryRunner: QueryRunner): Promise<void> {
		await queryRunner.query(
			"INSERT INTO `flower`(`id`, `name`, `description`, `image`, `price`, `blood`, `secondName`) VALUES (1, 'Bloodflower', 'Bloodflowers it has gained his name thank the red and white mixed colors, it just looks like the flower have been dipped into blood.', 'https://www.itl.cat/pngfile/big/16-165077_red-with-white-striped-rock-and-roll-rose.jpg', 11, 3, NULL), (2, 'Litnifitia', 'Litnifitia have an electic charge and just a few ponies can handle these flowers', 'https://4kwallpapers.com/images/walls/thumbs_3t/2066.jpg', 890, 10, 'Stormflower'), (3, 'Sakura', NULL, 'https://cache.desktopnexus.com/wallpapers/2554/2554513-1596x879-japanese_cherry_blossoms_macro-wallpaper-1600x900.jpg?st=sh3A4uzvYn9N_3ozULaKeA&e=1620396292', 890, 9, 'Cherry Blossom'), (4, 'Silverwing', 'eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee', '', 890, 10, NULL), (5, 'Bloodshot', 'Bloodshot is a difficult flower to grow, but with some care and love it will become a sweet and lovely flower.', NULL, 7, NULL, 'Blood'), (6, 'Sunflower', 'Sunflowers grow towards the sun.', 'https://hosstools.com/wp-content/uploads/2020/10/black-oil-sunflower.jpg', 8, NULL, NULL), (7, 'Rose', 'White and red', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSoOxCqYgtSEq7JXg7OMWZjfPzuolBPC_M5Aw&usqp=CAU', 10, NULL, NULL), (8, 'Poison joke', 'Poison joke is an infamous flower that grows in large patches throughout the Everfree Forest, easily identified by the bright blue colour of its leaves. As described by Zecora, \"That plant is much like poison oak, but its results are like a joke.\" Poison ', 'https://static.wikia.nocookie.net/twitterponies/images/4/4d/Poison_joke_flower.png', 1, NULL, NULL), (9, 'Passiflora caerulea', NULL, 'https://www.lovingly.com/wp-content/uploads/2020/06/passion-flower-815176_1920-1024x682.jpg', 99, NULL, 'blue passion flower'), (10, 'Lotus', 'Lotus flowers grow in/on water.', 'https://www.lovingly.com/wp-content/uploads/2020/06/jay-castor-7AcMUSYRZpU-unsplash-1024x683.jpg', 9, 2, NULL), (11, 'Amaryllis', NULL, 'https://www.lovingly.com/wp-content/uploads/2020/06/irene-grace-tolentino-OEgGE1MdiqE-unsplash-1024x683.jpg', 5, NULL, NULL);",
		);
	}

	public async down(queryRunner: QueryRunner): Promise<void> {}
}
