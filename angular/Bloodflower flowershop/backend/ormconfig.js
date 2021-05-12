module.exports = {
  type: 'mariadb',
  host: 'localhost',
  port: 3306,
  username: 'root',
  password: '',
  database: 'iluvcoffee',
  entities: ['dist/**/*.entity.js', 'src/**/entity/*.entity.ts'],
  migrations: ['dist/migrations/*.js'],
  cli: {
    migrationsDir: 'src/migrations',
  },
};
