create database user;
use user;

CREATE TABLE users(
   id_user int unique auto_increment,
   username varchar(64) NOT NULL,
   password varchar(64) NOT NULL,
   name varchar(64) NOT NULL,
   prenume varchar(64) NOT NULL,
   role varchar(64) NOT NULL,
   PRIMARY KEY(id_user)
);
CREATE TABLE film(
   id_film int unique auto_increment,
   titlu varchar(64) NOT NULL,
   regia varchar(64) NOT NULL,
   distributia varchar(64) NOT NULL,
   data_premiera datetime NOT NULL,
   ora datetime NOT NULL,
   nr_bilete int NOT NULL,
   data_finala datetime NOT NULL,
   PRIMARY KEY(id_film)
);

CREATE TABLE bilet(
   id_bilet int unique auto_increment,
   id_film int not null,
   rand int NOT NULL,
   loc int NOT NULL,
   dataFilm datetime NOT NULL,
   PRIMARY KEY(id_bilet),
   foreign key(id_film) references film(id_film)
);


Insert INTO users (username, password, name, prenume, role)
	values("Alexandra", "f7a3803365a55b197a3b43bc64aacc13", "Boldor", "Alexandra", "administrator");
Insert INTO users (username, password, name,prenume, role)
    values("Iulia", "48b08b5caf405b5e2859e0dbec4a6a4d", "Pop" ,"Iulia", "normal");

Insert INTO film (titlu, regia, distributia, data_premiera,ora, nr_bilete, data_finala)
	values("The very last morning", "Ciprian Mega", "", '2018-01-16', '2018-03-16 20:00:00',450,'2018-04-08');
Insert INTO film (titlu, regia, distributia, data_premiera,ora, nr_bilete, data_finala)
	values("Iron Man", "Production", "SSSS", '2018-05-16', '2018-08-16 22:00:00',300,'2018-04-29');
Insert INTO film (titlu, regia, distributia, data_premiera,ora, nr_bilete, data_finala)
	values("Black Box", "MMMMMM", "Aeros", '2018-06-16', '2018-08-16 18:00:00',250,'2018-10-08');
    
Insert INTO bilet (id_film, rand, loc, dataFilm)
	values(1, 12, 6, '2018-01-16');
    
select* from film;