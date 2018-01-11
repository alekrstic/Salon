-- Korisnici Fill
INSERT INTO KORISNIK(Id, Ime, Prezime, Username, Password, Obrisan, Tip_Korisnika) 
	VALUES (0, 'Pera', 'Peric', 'pera', '123', 0, 'ADMINISTRATOR')

INSERT INTO KORISNIK(Id, Ime, Prezime, Username, Password, Obrisan, Tip_Korisnika)  
	VALUES (1, 'Zika', 'Zikic', 'z', 'z', 0, 'PRODAVAC')
INSERT INTO KORISNIK(Id, Ime, Prezime, Username, Password, Obrisan, Tip_Korisnika)  
	VALUES (2, 'Acko', 'Ackovic', 'a', 'a', 0, 'PRODAVAC')
INSERT INTO KORISNIK(Id, Ime, Prezime, Username, Password, Obrisan, Tip_Korisnika) 
	VALUES (3, 'Marko', 'Markovic', 'm', 'm', 0, 'PRODAVAC')
INSERT INTO KORISNIK(Id, Ime, Prezime, Username, Password, Obrisan, Tip_Korisnika)  
	VALUES (4, 'Milos', 'Milosevic', 'mm', 'mm', 0, 'PRODAVAC')



-- Nameštaj Fill
INSERT INTO NAMESTAJ(Id, Naziv, Cena, Kolicina, Obrisan, Sifra, TipNamestajaID)
	VALUES(0, 'Krevet', 27500, 10, 0, 'k1', 1)

INSERT INTO NAMESTAJ(Id, Naziv, Cena, Kolicina, Obrisan, Sifra, TipNamestajaID)
	VALUES(1, 'Fotelja', 9750, 20, 0, 'k1', 1)
INSERT INTO NAMESTAJ(Id, Naziv, Cena, Kolicina, Obrisan, Sifra, TipNamestajaID)
	VALUES(2, 'Kuhinjski sto', 15000, 17, 0, 'ks1', 1)
INSERT INTO NAMESTAJ(Id, Naziv, Cena, Kolicina, Obrisan, Sifra, TipNamestajaID)
	VALUES(3, 'Dusek', 7500, 6, 0, 'd1', 1)
INSERT INTO NAMESTAJ(Id, Naziv, Cena, Kolicina, Obrisan, Sifra, TipNamestajaID)
	VALUES(4, 'Sto1', 12350, 20, 0, 's1', 1)
INSERT INTO NAMESTAJ(Id, Naziv, Cena, Kolicina, Obrisan, Sifra, TipNamestajaID)
	VALUES(5, 'Trpezarija', 20000, 47, 0, 't1', 1)
	-- Salon Fill
INSERT INTO SALON (Id, Naziv, Adresa, Telefon, Email, Sajt_adresa, Pib, Maticni_broj, Ziro_racun )
	VALUES (1, 'Salon !', 'Mileticeva', '55555', 'aaa@yahoo', 'www.a.com', 5555,55555,5566)

-- Prodaja Fill
INSERT INTO PRODAJA (Id, Kupac, BrojRacuna, UkupanIznos, DatumKadaJeProdato)
		VALUES(1, 'Marko Jevtovic', 15478,17.5,'2017-12-01')
--Usluga Fill
INSERT INTO USLUGA(Id, Naziv, Cena, Obrisan)
		VALUES(1, 'Dostava', 500, 0)
		--Akcija Fill
INSERT INTO AKCIJA (Id,DatumPocetka, DatumZavrsetka, Popust, Obrisan)
	VALUES(1,'03/03/2017','03/03/2018',10,0)
INSERT INTO AKCIJA (Id,DatumPocetka, DatumZavrsetka, Popust, Obrisan)
VALUES(2,'05/05/2017','02/03/2018',15,0)