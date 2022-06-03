	############################ Script VéloMax ##########################
  create database if not exists velomax;
    use velomax;
#Création administrateur root-root
CREATE USER IF NOT EXISTS 'root'@'localhost' IDENTIFIED BY 'root';
ALTER USER IF EXISTS 'root'@'localhost' IDENTIFIED BY 'root';

#Création user bozo-bozo sans les privilèges
CREATE USER IF NOT EXISTS 'bozo'@'localhost' IDENTIFIED BY 'bozo';
ALTER USER IF EXISTS 'bozo'@'localhost' IDENTIFIED BY 'bozo';
GRANT SELECT, SHOW VIEW ON VeloMax.* TO 'bozo'@'localhost';
FLUSH PRIVILEGES;
    
    
    
    CREATE TABLE IF NOT EXISTS modele(
	num_modele INT NOT NULL AUTO_INCREMENT,
	nom_modele VARCHAR(20) NOT NULL UNIQUE,
	grandeur VARCHAR(20) ,
	prix_unitaire_modele int,
	ligne_produit VARCHAR(40) ,
	date_intro_modele DATE,
	date_discon_modele DATE,
	stock_velo INT,
	PRIMARY KEY (num_modele,nom_modele,grandeur));	
    
    
    	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (101, 'Kilimandjaro', 'Adultes', 569, 'VTT','2020-05-12','2023-05-12',2);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (102, 'NorthPole', 'Adultes', 329, 'VTT','2020-05-12','2023-05-12',133);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (103, 'MontBlanc', 'Jeunes', 399, 'VTT','2020-05-12','2023-05-12',90);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (104, 'Hooligan', 'Jeunes', 199, 'VTT','2020-05-12','2023-05-12',14);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (105, 'OrléansH', 'Hommes', 229, 'Vélo de course','2020-05-12','2023-05-12',20);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (106, 'OrléansD', 'Dames', 229, 'Vélo de course','2020-05-12','2023-05-12',15);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (107, 'BlueJayH', 'Hommes', 349, 'Vélo de course','2020-05-12','2023-05-12',19);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (108, 'BlueJayF', 'Dames', 349, 'Vélo de course','2020-05-12','2023-05-12',30);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (109, 'Trail ExplorerF', 'Filles', 129, 'Classique','2020-05-12','2023-05-12',200);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (110, 'Trail ExplorerG', 'Garçons', 129, 'Classique','2020-05-12','2023-05-12',10);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (111, 'Night Hawk', 'Jeunes', 189, 'Classique','2020-05-12','2023-05-12',176);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (112, 'Tierra VerdeH', 'Hommes', 199, 'Classique','2020-05-12','2023-05-12',80);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (113, 'Tierra VerdeD', 'Dames', 199, 'Classique','2020-05-12','2023-05-12',40);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (114, 'Mud Zinger I', 'Jeunes', 279, 'BMX','2020-05-12','2023-05-12',23);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (115, 'Mud Zinger II', 'Adultes', 359, 'BMX','2020-05-12','2023-05-12',45);
	INSERT INTO `velomax`.`modele` (`num_modele`, `nom_modele`, `grandeur`, `prix_unitaire_modele`, `ligne_produit`,`date_intro_modele`,`date_discon_modele`,`stock_velo`) VALUES (115, '0', 'Adultes', 359, 'BMX','2020-05-12','2023-05-12',0);
    
    DROP TABLE IF EXISTS assemblage;
CREATE TABLE IF NOT EXISTS assemblage(
num_modele INT,
nom_modele VARCHAR(20) NOT NULL,
grandeur VARCHAR(20) NOT NULL,
cadre VARCHAR(10) ,
guidon VARCHAR(10) ,
freins VARCHAR(10) ,
selle VARCHAR(10) NOT NULL,
derailleur_av VARCHAR(10) ,
derailleur_ar VARCHAR(10) ,
roue_av VARCHAR(10) NOT NULL,
roue_ar VARCHAR(10) NOT NULL,
reflecteurs VARCHAR(10) ,
pedalier VARCHAR(10) NOT NULL,
ordinateur VARCHAR(10) ,
panier VARCHAR(10) ,

FOREIGN KEY (num_modele ,nom_modele,grandeur)
       REFERENCES modele (num_modele ,nom_modele,grandeur),
PRIMARY KEY (nom_modele,grandeur));


INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Kilimandjaro','Adultes','C32','G7','F3','S88','DV133','DR56','R45','R46',null,'P12','O2',null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('NorthPole','Adultes','C34','G7','F3','S88','DV17','DR87','R48','R47',null,'P12',null,null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('MontBlanc','Jeunes','C76','G7','F3','S88','DV17','DR87','R48','R47',null,'P12','O2',null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Hooligan','Jeunes','C76','G7','F3','S88','DV87','DR86','R12','R32',null,'P12',null,null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Orléans','Hommes','C43','G9','F9','S37','DV57','DR86','R19','R18','R02','P34',null,null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Orléans','Dames','C44f','G9','F9','S35','DV57','DR86','R19','R18','R02','P34',null,null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('BlueJay','Hommes','C43','G9','F9','S37','DV57','DR87','R19','R18','R02','P34','O4',null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('BlueJay','Dames','C43f','G9','F9','S35','DV57','DR87','R19','R18','R02','P34','O4',null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Trail Explorer','Filles','C01','G12',null,'S02',null,null,'R1','R2','R09','P1',null,'S01');
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Trail Explorer','Garçons','C02','G12',null,'S03',null,null,'R1','R2','R09','P1',null,'S05');
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Night Hawk','Jeunes','C15','G12','F9','S36','DV15','DR23','R11','R12','R10','P15',null,'S74');
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Tierra Verde','Hommes','C87','G12','F9','S36','DV41','DR76','R11','R12','R10','P15',null,'S74');
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Tierra Verde','Dames','C87f','G12','F9','S34','DV41','DR76','R11','R12','R10','P15',null,'S73');
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Mud Zinger I','Jeunes','C25','G7','F3','S87','DV132','DR52','R44','R47',null,'P12',null,null);
INSERT INTO `velomax`.`assemblage` (`nom_modele`, `grandeur`, `cadre`, `guidon`, `freins`,`selle`,`derailleur_av`,`derailleur_ar`,`roue_av`,`roue_ar`,`reflecteurs`,`pedalier`,`ordinateur`,`panier`) 
VALUES ('Mud Zinger II','Adultes','C26','G7','F3','S87','DV133','DR52','R44','R47',null,'P12',null,null);
    
    
    create table if not exists Entreprise
	(
	id_entreprise int NOT NULL AUTO_INCREMENT,
	nom_entreprise varchar(255) NOT NULL UNIQUE,
	rue_entreprise varchar(255),
	ville_entreprise varchar(255),
	codeP_entreprise  int,
	province_entreprise varchar(255),
	tel_entreprise varchar(255),
	courriel_entreprise varchar(255),
	nom_contact varchar(255),
	remise_e varchar(255),
	PRIMARY KEY (id_entreprise, nom_entreprise)
	);
    
    
    
	INSERT INTO `velomax`.`Entreprise` (`nom_entreprise`, `rue_entreprise`, `ville_entreprise`, `codeP_entreprise`,`province_entreprise`,`tel_entreprise`,`courriel_entreprise`,`nom_contact`,`remise_e`) 
VALUES ('Condax','27 Boulevard de Normandie','Fontenay-aux-Roses',92260,'Ile-de-France',0110187860,'condax@weber.com','Michelle Guichard','0');
INSERT INTO `velomax`.`Entreprise` (`nom_entreprise`, `rue_entreprise`, `ville_entreprise`, `codeP_entreprise`,`province_entreprise`,`tel_entreprise`,`courriel_entreprise`,`nom_contact`,`remise_e`) 
VALUES ('Openlane','55 Avenue des Tuileries','Grigny',91350,'Ile-de-France',0121996677,'openlane@free.fr','Julien Desforges','5');
INSERT INTO `velomax`.`Entreprise` (`nom_entreprise`, `rue_entreprise`, `ville_entreprise`, `codeP_entreprise`,`province_entreprise`,`tel_entreprise`,`courriel_entreprise`,`nom_contact`,`remise_e`) 
VALUES ('Flash','30 rue de la Hulotais','Saint-Raphael',83700,'PACA',0431494081,'flash@orange.fr','Sébastien Langelier','5');
INSERT INTO `velomax`.`Entreprise` (`nom_entreprise`, `rue_entreprise`, `ville_entreprise`, `codeP_entreprise`,`province_entreprise`,`tel_entreprise`,`courriel_entreprise`,`nom_contact`,`remise_e`) 
VALUES ('Superman','15 rue des buissons','Smallville',92284,'IDF',0435874081,'clark@orange.fr','Clark Kent','20');
INSERT INTO `velomax`.`Entreprise` (`nom_entreprise`, `rue_entreprise`, `ville_entreprise`, `codeP_entreprise`,`province_entreprise`,`tel_entreprise`,`courriel_entreprise`,`nom_contact`,`remise_e`) 
VALUES ('Green Arrow','35 allee des flechettes','Starcity',7884,'IDF',073587681,'oliver@gmail.fr','Oliver Queen','0');

create table if not exists fidelio(
	n_programme enum('5','1','2','3','4'),
	descriptions varchar(255),
	
	cout int,
	duree int,
	rabais int,
	primary key(n_programme));
    
    insert into velomax.fidelio(n_programme,descriptions,cout,duree,rabais)
	values (5,'pas Fidélio',0,0,0); 
	insert into velomax.fidelio(n_programme,descriptions,cout,duree,rabais)
	values (1,'Fidélio',15,1,5);
	insert into velomax.fidelio(n_programme,descriptions,cout,duree,rabais)
	values (2,'Fidélio Or',25,2,8);
	insert into velomax.fidelio(n_programme,descriptions,cout,duree,rabais)
	values (3,'Fidélio Platine',60,2,10);
	insert into velomax.fidelio(n_programme,descriptions,cout,duree,rabais)
	values (4,'Fidélio Diamant',100,3,12);

	create table if not exists Individuel
	(
	id_client int NOT NULL AUTO_INCREMENT,
	nom_client varchar(255) NOT NULL UNIQUE,
	prenom_client varchar(255),
	rue_client varchar(255),
	ville_client varchar(255),
	codeP_client  int,
	province_client varchar(255),
	tel_client varchar(255),
	mail_client varchar(255),
	n_programme enum('1','2','3','4','5'),
	date_adhesion date,
	FOREIGN KEY (n_programme) References fidelio(n_programme),
	PRIMARY KEY (id_client, nom_client)
	);
insert into Individuel (nom_client,prenom_client,rue_client,ville_client,codeP_client,province_client,tel_client, mail_client, n_programme, date_adhesion)
			values ('Dandonneau','Alexandrie','20 Cours Maréchal Joffre','Deuil-la-Barre',95170,'Ile-de-France','0178370386','alexandriedandonneau@gmail.com', 1, "2020-05-22");
	insert into Individuel (nom_client,prenom_client,rue_client,ville_client,codeP_client,province_client,tel_client, mail_client, n_programme, date_adhesion)
			values ('Nazaaha Antoun','Shahd','16 rue du Clair Bocage','La Seyne-sur-Mer',83500,'PACA','0479822731','shahd@dayrep.com',2,"2012-04-15");
	insert into Individuel (nom_client,prenom_client,rue_client,ville_client,codeP_client,province_client,tel_client, mail_client, n_programme, date_adhesion)
			values ('Kê','Yuan','6 rue des six frères Ruellan','Sarreguemines',57200,'Moselle','0358540708',null,4,"2012-04-15");
	insert into Individuel (nom_client,prenom_client,rue_client,ville_client,codeP_client,province_client,tel_client, mail_client, n_programme, date_adhesion)
			values ('Sullivan','chloe','5 avenue des roches','Smallville',74589,'IDF','0358890708',null,4,"2020-04-15");
	insert into Individuel (nom_client,prenom_client,rue_client,ville_client,codeP_client,province_client,tel_client, mail_client, n_programme, date_adhesion)
			values ('Lang','Lana','14 cours des roches','Smallville',74589,'IDF','0458890708',null,1,"2022-04-15");
	insert into Individuel (nom_client,prenom_client,rue_client,ville_client,codeP_client,province_client,tel_client, mail_client, n_programme, date_adhesion)
    values ('Snow','Caitlin','5 allee voltaire','Centralcity',74559,'IDF','0624050708',null,1,"2022-03-15");
CREATE TABLE IF NOT EXISTS fournisseur(
	siret VARCHAR(40) NOT NULL,
	nom_fournisseur VARCHAR(40) NOT NULL,
	contact VARCHAR(40) ,
	rue_fournisseur VARCHAR(255) NOT NULL,
	ville_fournisseur VARCHAR(40) NOT NULL,
	codeP_fournisseur INT NOT NULL,
	province_fournisseur VARCHAR(40) NOT NULL,
	libelle ENUM('1','2','3','4'),
	PRIMARY KEY (siret,nom_fournisseur)
	);
INSERT INTO `velomax`.`fournisseur` (`siret`, `nom_fournisseur`,`contact`, `rue_fournisseur`, `ville_fournisseur`,`codeP_fournisseur`,`province_fournisseur`,`libelle`) 
	VALUES ('213 291 800 66696','Bike Finders','bikefinder@gmail.com','4 rue Jean Vilar','Beauvais',60000,'Hauts-de-France',3);
	INSERT INTO `velomax`.`fournisseur` (`siret`, `nom_fournisseur`,`contact`, `rue_fournisseur`, `ville_fournisseur`,`codeP_fournisseur`,`province_fournisseur`,`libelle`) 
	VALUES ('320 732 290 72185','Cyrus','cyrus@gmail.com','49 rue Isambard','Fougères',35300,'Bretagne',1);
	INSERT INTO `velomax`.`fournisseur` (`siret`, `nom_fournisseur`,`contact`, `rue_fournisseur`, `ville_fournisseur`,`codeP_fournisseur`,`province_fournisseur`,`libelle`) 
	VALUES ('715 257 648 00413','Spare One','spareone@gmail.com','19 rue Hubert de Lisle','Loos',59120,'Hauts-de-France',4);
	INSERT INTO `velomax`.`fournisseur` (`siret`, `nom_fournisseur`,`contact`, `rue_fournisseur`, `ville_fournisseur`,`codeP_fournisseur`,`province_fournisseur`,`libelle`) 
	VALUES ('515 257 648 00415','Valeo','valeo@gmail.com','19 rue jpp','Lille',45135,'Hauts-de-France',4);
	INSERT INTO `velomax`.`fournisseur` (`siret`, `nom_fournisseur`,`contact`, `rue_fournisseur`, `ville_fournisseur`,`codeP_fournisseur`,`province_fournisseur`,`libelle`) 
	VALUES ('876 287 678 00235','Norauto','norauto@gmail.com','19 rue osecour','Poitiers',32654,'Centre',4);

	DROP Table if exists pieceRechange;
	CREATE TABLE IF NOT EXISTS pieceRechange(
	num_piece VARCHAR(255),
	siret VARCHAR(255) NOT NULL,
	nom_fournisseur VARCHAR(40) NOT NULL,
	description_piece VARCHAR(50) NOT NULL UNIQUE,
	num_catalogue INT NOT NULL,
	prix_piece INT NOT NULL,
	date_intro_piece DATE,
	date_discon_piece DATE,
	delais INT NOT NULL,
	stock_piece INT,

	FOREIGN KEY (siret,nom_fournisseur)
			 REFERENCES fournisseur (siret,nom_fournisseur),

	PRIMARY KEY(num_piece,siret,nom_fournisseur));
    
    
	INSERT INTO `velomax`.`pieceRechange` (`num_piece`, `description_piece`, `siret`, `nom_fournisseur`, `num_catalogue`, `prix_piece`,`date_intro_piece`,`date_discon_piece`,`delais`,`stock_piece`) 
	VALUES ('F3','Freins','515 257 648 00415','Valeo',12,30,'2009-06-26',null,3,3);
	INSERT INTO `velomax`.`pieceRechange` (`num_piece`, `description_piece`, `siret`, `nom_fournisseur`, `num_catalogue`, `prix_piece`,`date_intro_piece`,`date_discon_piece`,`delais`,`stock_piece`) 
	VALUES ('C75','Cadre','515 257 648 00415','Valeo',11,30,'2008-06-26','2018-07-12',10,50);
	INSERT INTO `velomax`.`pieceRechange` (`num_piece`, `description_piece`, `siret`, `nom_fournisseur`, `num_catalogue`, `prix_piece`,`date_intro_piece`,`date_discon_piece`,`delais`,`stock_piece`) 
	VALUES ('R10','Reflécteurs','876 287 678 00235','Norauto',345,5,'2015-04-07',null,5,12);
	INSERT INTO `velomax`.`pieceRechange` (`num_piece`, `description_piece`, `siret`, `nom_fournisseur`, `num_catalogue`, `prix_piece`,`date_intro_piece`,`date_discon_piece`,`delais`,`stock_piece`) 
	VALUES ('0','0','876 287 678 00235','Norauto',345,5,'2015-04-07',null,5,12);
	

	create table if not exists commande_individuel(
	id_commande_individuel INT NOT NULL AUTO_INCREMENT,
	nom_client varchar(255) NOT NULL,
	nom_modele varchar(20),
	description_piece varchar(20),
	quantite int,
	rue_livraison varchar(255),
	ville_livraison varchar(255),
	codeP_livraison int,
	province_livraison varchar(255),
	date_livraison date,
	date_commande date,
	foreign key(nom_client) references Individuel(nom_client),
	foreign key(nom_modele) references modele(nom_modele),
	foreign key(description_piece) references pieceRechange(description_piece),
	PRIMARY KEY (id_commande_individuel)
	);
    
    	insert into velomax.commande_individuel (id_commande_individuel,nom_client , nom_modele, description_piece, quantite, rue_livraison, ville_livraison,codeP_livraison,	province_livraison,date_livraison,date_commande)
	values (1,'Dandonneau','0','Cadre', 8, '45 rue Victor Hugo', 'Poitiers', 86000, 'Vienne', '2021-09-15', '2021-09-18');
insert into velomax.commande_individuel (id_commande_individuel,nom_client , nom_modele, description_piece, quantite, rue_livraison, ville_livraison,codeP_livraison,	province_livraison,date_livraison,date_commande)
	values (2,'Kê','MontBlanc','0', 5,'6 rue des six frères Ruellan','Sarreguemines',57200,'Moselle', '2021-08-12', '2021-08-14');
insert into velomax.commande_individuel (id_commande_individuel,nom_client , nom_modele, description_piece, quantite, rue_livraison, ville_livraison,codeP_livraison,	province_livraison,date_livraison,date_commande)
	values (3,'Lang','MontBlanc','0', 5,'14 cours des roches','Sarreguemines',57200,'IDF', '2021-08-12', '2021-08-14');
insert into velomax.commande_individuel (id_commande_individuel,nom_client , nom_modele, description_piece, quantite, rue_livraison, ville_livraison,codeP_livraison,	province_livraison,date_livraison,date_commande)
	values (4,'Snow',null,'Cadre', 5,'55 rue Starlab','Centralcity',57200,'IDF', '2021-08-12', '2021-08-14');
    insert into velomax.commande_individuel (id_commande_individuel,nom_client , nom_modele, description_piece, quantite, rue_livraison, ville_livraison,codeP_livraison,	province_livraison,date_livraison,date_commande)
	values (5,'Snow','Montblanc','0', 5,'55 rue Starlab','Centralcity',57200,'IDF', '2021-08-12', '2021-08-14');

	create table if not exists commande_e(
	id_commande_e INT NOT NULL AUTO_INCREMENT,
	nom_e varchar(255) NOT NULL,
	nom_modele varchar(20),
	description_piece varchar(20),
	quantite int,
	rue_livraison varchar(255),
	ville_livraison varchar(255),
	codeP_livraison int,
	province_livraison varchar(255),
	date_livraison date,
	date_commande date,
	foreign key(nom_e) references Entreprise(nom_entreprise),
	foreign key(nom_modele) references modele(nom_modele),
	foreign key(description_piece) references pieceRechange(description_piece),
	PRIMARY KEY (id_commande_e)
	);
    
	insert into velomax.commande_e (id_commande_e,nom_e, nom_modele, description_piece, quantite, rue_livraison, ville_livraison,codeP_livraison,province_livraison,date_livraison,date_commande)
	values (1,'Flash','NorthPole','0', 5, '30 rue de la Hulotais', 'Saint-Raphael',83700,'PACA', '2022-05-08', '2022-05-12');
	insert into velomax.commande_e (id_commande_e,nom_e, nom_modele, description_piece, quantite, rue_livraison, ville_livraison,codeP_livraison,province_livraison,date_livraison,date_commande)
	values (2,'Openlane','MontBlanc','0', 10, '55 Avenue des Tuileries','Grigny',91350,'Ile-de-France', '2021-04-12', '2021-04-16');



    









