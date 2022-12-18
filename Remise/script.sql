--creation de la base de donne--
create database Cartage
use Cartage

--creation des tables--
create table Crystalien
(
	Matricule char(6) primary key,
	Nom varchar(max),
	Droit int,
	habitant varchar(10)
)

create table Mission
(
	ID int primary key,
	mission_pour char(6),
	mission_de char(6),
	string varchar(max),
	statue int
)

create table Fee
(
	Matricule char(6) primary key,
	Nom varchar(max),
	Droit int,
	proprietaire_de varchar(10)
)

--Insertion de valeur--
insert into Crystalien(Matricule,Nom,Droit,habitant)
values('CR2429','Guillaume',3,'Langitia'),
('CR0800','Slimile',2,'Langitia'),
('CR2430','Alex',1,'Langitia')

insert into Fee(Matricule,Nom,Droit,proprietaire_de)
values('FC0001','Suyi',3,'Langitia'),
('FC0002','Xania',3,'Lurminia'),
('FC0003','Messio',3,'Cartage'),
('FC0004','Éclacite',3,'Vierde'),
('FC0005','Rémiace',3,'Technoria')