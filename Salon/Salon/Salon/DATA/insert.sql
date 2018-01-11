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
INSERT INTO SALON(id, naziv, adresa, telefon, email, adresasajta, pib, maticnibroj, brziroracuna)
	VALUES(1, 'Salon FTN', 'Trg Dositeja Obradovi?a', 0603636363, 'mail@uns.ac.rs', 'www.ftn.un?.ac.rs', 21000, 123456789, '36-666123-36')