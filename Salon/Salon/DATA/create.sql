USE master
GO
DROP DATABASE IF EXISTS SalonDB
GO
CREATE DATABASE SalonDB
GO
USE SalonDB
GO
DROP TABLE IF EXISTS KORISNIK
GO
CREATE TABLE KORISNIK
(
	Id INT not null,
	Ime VARCHAR(15) not null, 
	Prezime VARCHAR(15) not null,
	Username VARCHAR(20) not null,
	Password  VARCHAR(20) not null,
	Obrisan BIT not null,
	Tip_Korisnika VARCHAR(15) not null,
)
DROP TABLE IF EXISTS NAMESTAJ
GO
CREATE TABLE NAMESTAJ
(
	Id INT not null,
	Naziv VARCHAR(20) not null,
	Cena INT not null,
	Kolicina INT not null,
	Obrisan BIT not null,
	Sifra varchar(20) not null,
	TipNamestajaID INT not null
	
)
DROP TABLE IF EXISTS SALON
GO
CREATE TABLE SALON
(
	Id INT not null,
	Naziv VARCHAR(40) not null,
	Adresa VARCHAR(40) not null,
	Telefon INT not null,
	Email VARCHAR(30) not null,
	Sajt_adresa VARCHAR(40) not null,
	Pib INT not null,
	Maticni_broj INT not null,
	Ziro_racun VARCHAR(40) not null
)