-- 1. Kroz SQL kod kreirati bazu podataka Vjezba2
GO 
use Vjezba2
-- 2. U pomenutoj bazi kreirati šemu Prodaja
go
create schema Prodaja
go

-- 3. U šemi Prodaja kreirati tabele sa sljedećom strukturom:
	-- Autori
		--• AutorID, 11 karaktera i primarni ključ
		--• Prezime, 40 karaktera (obavezan unos)
		--• Ime, 20 karaktera (obavezan unos)
		--• Telefon, 12 karaktera fiksne dužine, zadana vrijednost „nepoznato“
		--• Adresa, 40 karaktera
		--• SaveznaDrzava, 2 karaktera fiksne dužine
		--• PostanskiBroj, 5 karaktera fiksne dužine
		--• Ugovor, bit polje (obavezan unos)
create table Prodaja.Autori
(
	AutorID varchar(11) constraint PK_Autori primary key,
	Prezime varchar(40) NOT NULL,
	Ime varchar(20) NOT NULL,
	Telefon char(12) default 'nepoznato',
	Adresa varchar(40),
	SaveznaDrzava char(2),
	PostanskiBroj char(5),
	Ugovor bit NOT NULL
)
	-- Knjige
		--• KnjigaID, 6 karaktera i primarni ključ
		--• Naziv, 80 karaktera (obavezan unos)
		--• Vrsta, 12 karaktera fiksne dužine (obavezan unos)
		--• IzdavacID, 4 karaktera fiksne duzine
		--• Cijena, novčani tip podatka
		--• Biljeska, 200 karaktera
		--• Datum, datumsko-vremenski tip
create table Prodaja.Knjige
(
	KnjigaID varchar(6) constraint PK_Knjige primary key,
	Naziv varchar(80) NOT NULL,
	Vrsta varchar(12) NOT NULL,
	IzdavacID char(4) ,
	Cijena money,
	Biljeska varchar(200),
	Datum datetime
)
-- 4. Upotrebom insert naredbe iz tabele Publishers baze Pubs izvršiti kreiranje i insertovanje podataka u tabelu Izdavaci šeme Prodaja (Nazivi kolona trebaju biti na bosanskom jeziku)
select 
	p.pub_id as 'IzdavacID',
	p.pub_name as 'Naziv',
	p.city as 'Grad',
	p.state as 'SaveznaDrzava',
	p.country as 'Drzava'
into Prodaja.Izdavaci
from pubs.dbo.publishers as p
-- 5. U kreiranoj tabeli Izdavaci provjeriti koje polje je primarni ključ, ukoliko ga nema, prikladno polje proglasiti primarnim ključem
alter table Prodaja.Izdavaci
add constraint PK_Izdavaci primary key(IzdavacID)
-- 6. Povezati tabelu Izdavaci sa tabelom Knjige, po uzoru na istoimene tabele baze Pubs
alter table Prodaja.Knjige
add constraint FK_Knjige_Izdavaci foreign key(IzdavacID) references Prodaja.Izdavaci(IzdavacID)
-- 7. U šemu Prodaja dodati tabelu sa sljedećom strukturom
	-- AutoriKnjige
		--• AutorID 11 karaktera, spoljni ključ
		--• KnjigaID 6 karaktera, spoljni ključ
		--• AuOrd kratki cjelobrojni tip podatka
		--• **Definisati primarni ključ po uzoru na tabelu TitleAuthor baze Pubs

create table Prodaja.AutoriKnjige
(
	AutorID varchar(11) constraint FK_AutoriKnjige_Autori foreign key references Prodaja.Autori(AutorID),
	KnjigaID varchar(6) constraint FK_AutoriKnjige_Knjige foreign key references Prodaja.Knjige(KnjigaID),
	AuOrd tinyint,
	constraint PK_AutoriKnjige primary key(AutorID, KnjigaID) 
)
-- 8. U kreirane tabele izvršiti insert podataka iz baze Pubs (Za polje biljeska tabele Knjige na mjestima gdje je vrijednost NULL pohraniti „nepoznata vrijednost“)

insert into Prodaja.Knjige
select t.title_id, t.title, t.type, t.pub_id, t.price, isnull(t.notes, 'nepoznata vrijednost'), t.pubdate
from pubs.dbo.titles as t

insert into Prodaja.Autori
select a.au_id, a.au_lname, a.au_fname, a.phone, a.address, a.state, a.zip, a.contract
from pubs.dbo.authors as a

insert into Prodaja.AutoriKnjige
select t.au_id, t.title_id, t.au_ord
from pubs.dbo.titleauthor as t
-- 9. U tabeli Autori nad kolonom Adresa promijeniti tip podatka na nvarchar (40)
alter table Prodaja.Autori
alter column Adresa nvarchar(40)

-- 10. Prikazati sve autore čije ime počinje sa slovom A ili S
select *
from Prodaja.Autori as a
where upper(a.Ime) like 'A%' or upper(a.Ime) like 'S%'

-- 11. Prikazati knjige gdje cijena nije unesena
select *
from Prodaja.Knjige as k
where k.Cijena is null

-- 12. U tabeli Izdavaci nad poljem NazivIzdavaca postaviti ograničenje kojim se onemogućuje unos duplikata
alter table Prodaja.Izdavaci
add constraint UQ_Izdavaci_Naziv unique(Naziv)
-- 13. Prikladnim primjerima testirati postavljeno ograničenje na polju NazivIzdavaca

insert into Prodaja.Izdavaci(IzdavacID, Naziv)
values ('AAAB', 'Nejla')

-- 14. U bazi Vjezba2 kreirati šemu Narudzbe

create schema Narudzbe

-- 15. Upotrebom insert naredbe iz tabele Region baze Northwind izvršiti kreiranje i insertovanje podataka u tabelu Regije šeme Narudžbe

select *
into Narudzbe.Regije
from Northwind.dbo.Region 

-- 16. Prikazati sve podatke koji se nalaze u tabeli Regije
select *
from Narudzbe.Regije

-- 17. U tabelu Regije insertovati zapis:
	-- 5 SE

insert into Narudzbe.Regije(RegionID, RegionDescription)
values (5, 'SE')
-- 18. U tabelu Regije insertovati zapise:
	-- 6 NE
	-- 7 NW
insert into Narudzbe.Regije(RegionID, RegionDescription)
values (6, 'NE'),
		(7, 'NW')
-- 19. Upotrebom insert naredbe iz tabele OrderDetails baze Northwind izvršiti kreiranje i insertovanje podataka u tabelu StavkeNarudzbe šeme Narudzbe
select *
into Narudzbe.StavkeNarudzbe
from Northwind.dbo.[Order Details]
-- 20. U tabeli StavkeNarudzbe dodati standardnu kolonu ukupno tipa decimalni broj (8,2).
alter table Narudzbe.StavkeNarudzbe 
add Ukupno decimal(8,2)

-- 21. Izvršiti update kreirane kolone kao umnožak kolona Quantity i UnitPrice.
UPDATE Narudzbe.StavkeNarudzbe
SET Ukupno = Quantity * UnitPrice --Update-a samo vec dodane kolone tj. mora se pozvati svaki put kad se doda novi zapis

alter table Narudzbe.StavkeNarudzbe 
add Ukupno2 as (ROUND(Quantity * UnitPrice, 2)) --Automatski se racuna i update-a kolona nakon dodavanja novog zapisa

insert into Narudzbe.StavkeNarudzbe(OrderID, ProductID, UnitPrice, Quantity, Discount)
values (3000, 11, 15, 2, 0) 

select * 
from Narudzbe.StavkeNarudzbe
where OrderID=3000
-- 22. U tabeli StavkeNarduzbe dodati izračunatu kolonu CijeliDio(broj ispred decimalnog zareza) u kojoj će biti cijeli dio iz kolone UnitPrice
alter table Narudzbe.StavkeNarudzbe
add CijeliDio as floor(UnitPrice)
-- 23. U tabeli StavkeNarduzbe kreirati ograničenje na koloni Discount kojim će se onemogućiti unos vrijednosti manjih od 0.
alter table Narudzbe.StavkeNarudzbe
add constraint CK_StavkeNarudzbe_Discount check(Discount between 0 and 1)
-- 24. U tabelu StavkeNarudzbe insertovati novi zapis (potrebno je testirati postavljeno ograničenje)

-- 25. U šemu Narudzbe dodati tabelu sa sljedećom strukturom:
	-- Kategorije
		--• KategorijaID, cjelobrojna vrijednost, primarni ključ i autoinkrement
		--• NazivKategorije, 15 UNICODE znakova (obavezan unos)
		--• Opis, tekstualan UNICODE tip podatka
create table Narudzbe.Kategorije
(
	KategorijaID int constraint PK_Kategorije primary key identity(1, 1),
	Naziv nvarchar(15) NOT NULL,
	Opis ntext
)

-- 26. U kreiranu tabelu izvršiti insertovanje podataka iz tabele Categories baze Northwind

set identity_insert Narudzbe.Kategorije on
insert into Narudzbe.Kategorije(KategorijaID, Naziv, Opis)
select c.CategoryID, c.CategoryName, c.Description
from Northwind.dbo.Categories as c
set identity_insert Narudzbe.Kategorije off

-- 27. U tabelu Kategorije insertovati novu kategoriju pod nazivom „Ncategory“

insert into Narudzbe.Kategorije(Naziv)
values ('Ncategory')

-- 28. Kreirati upit kojim će se prikazati sve kategorije

select *
from Narudzbe.Kategorije

-- 29. Izvršiti update zapisa u tabeli Kategorije na mjestima gdje Opis kategorije nije dodan pohraniti vrijednost „bez opisa“

update Narudzbe.Kategorije
set Opis='bez opisa'
where Opis is null

alter table Narudzbe.Kategorije
add constraint DF_Kategorije_Opis default 'bez opis' for Opis

-- 30. Izvršiti brisanje svih kategorija

delete Narudzbe.Kategorije
where KategorijaID = 9

-- ::Primjer ispitnog DDL i INSERT zadatka::
-- 1. U šemu Narudzbe dodati tabelu sa sljedećom strukturom:
	-- Proizvodi
		--• ProizvodID, cjelobrojna vrijednost i primarni ključ, autoinkrement
		--• Naziv, 50 UNICODE karaktera (obavezan unos)
		--• SifraProizvoda, 25 UNICODE karaktera (obavezan unos)
		--• Boja, 15 UNICODE karaktera
		--• NazivKategorije, 50 UNICODE (obavezan unos)
		--• Tezina, decimalna vrijednost sa 2 znaka iza zareza
create table Narudzbe.Proizvodi
(
	ProizvodID int constraint PK_Proizvodi primary key identity(1, 1),
	Naziv NVARCHAR(50) NOT NULL,
    SifraProizvoda NVARCHAR(25) NOT NULL,
    Boja NVARCHAR(15) NULL,
    NazivKategorije NVARCHAR(50) NOT NULL,
    Tezina DECIMAL(10,2) NULL
)
-- 2. Iz baze podataka AdventureWorks2017 u tabelu Proizvodi dodati sve proizvode, na mjestima gdje nema pohranjenih podataka o težini zamijeniti vrijednost sa 0
		--• ProductID -> ProizvodID
		--• Name -> Naziv
		--• ProductNumber -> SifraProizvoda
		--• Color -> Boja
		--• Name (ProductCategory) -> NazivKategorije
		--• Weight -> Tezina
--insert into Narudzbe.Proizvodi
--from 
-- ::Dodatni zadaci za vježbu::
-- 1. Kroz SQL kod kreirati bazu podataka ZadaciZaVjezbu2
create database ZadaciZaVjezbu2
go 
use ZadaciZaVjezbu2
-- 2. U pomenutoj bazi kreirati šemu Prodaja
go
create schema Prodaja
go
-- 3. U kreiranoj bazi podataka kreirati tabele sa sljedećom strukturom:
	-- a) Proizvodi
		--• ProizvodID, cjelobrojna vrijednost, autoinkrement i primarni ključ
		--• Naziv, 40 UNICODE karaktera (obavezan unos)
		--• Cijena, novčani tip
		--• KolicinaNaSkladistu,skraćeni cjelobrojni tip
		--• Raspolozivost, bit polje (obavezan unos)
create table Prodaja.Proizvodi
(
	ProizvodID int constraint PK_Proizvodi primary key identity(1, 1),
	Naziv nvarchar(40) NOT NULL,
	Cijena money,
	KoliicnaNaSkladistu tinyint,
	Raspolozivost bit NOT NULL,
)
	-- b) Kupci
		--• KupacID, 5 UNICODE fiksna karaktera i primarni ključ
		--• NazivKompanije, 40 UNICODE karaktera (obavezan unos)
		--• Ime, 30 UNICODE karaktera
		--• Telefon, 24 UNICODE karaktera
		--• Faks, 24 UNICODE karaktera
create table Prodaja.Kupci 
(
	KupacID nvarchar(5) constraint PK_Kucpi primary key,
	NazivKompanije nvarchar(40) NOT NULL,
	Ime NVARCHAR(30),
	Telefon nvarchar(24),
	Faks nvarchar(24)
)
	-- c) Narudzbe
		--• NarudzbaID, cjelobrojna vrijednost, autoinkrement i primarni ključ,
		--• DatumNarudzbe, polje za unos datuma
		--• DatumPrijema, polje za unos datuma
		--• DatumIsporuke, polje za unos datuma
		--• Drzava, 15 UNICODE karaktera
		--• Regija, 15 UNICODE karaktera
		--• Grad, 15 UNICODE karaktera
		--• Adresa, 60 UNICODE karaktera
create table Prodaja.Narudzbe
(
	NarudzbaID int constraint PK_Narudzbe primary key identity(1, 1),
	DatumNarudzbe date,
	DatumPrijema date, 
	DatumIsporuke date,
	Drzava nvarchar(15),
	Regija nvarchar(15),
	Grad nvarchar(15),
	Adresa nvarchar(60),
)
	-- d) StavkeNarudzbe
		--• NarudzbaID, cjelobrojna vrijednost, strani ključ
		--• ProizvodID, cjelobrojna vrijednost, strani ključ
		--• Cijena, novčani tip (obavezan unos),
		--• Kolicina, skraćeni cjelobrojni tip (obavezan unos) i defaultna vrijednost (1),
		--• Popust, realna vrijednost (obavezan unos)
		--• VrijednostStavki narudžbe (uzeti u obzir i popust)- calculated polje
		--**Definisati primarni ključ tabele
create table Prodaja.StavkeNarudzbe
(
	NarudzbaID int constraint FK_StavkeNarudzbe_Narudzbe foreign key references Prodaja.Narudzbe,
	ProizvodID int constraint FK_StavkeNarudzbe_Proizvodi foreign key references Prodaja.Proizvodi,
	constraint PK_StavkeNarudzbe primary key(NarudzbaID, ProizvodID),
	Cijena money NOT NULL,
	Kolicina SMALLINT NOT NULL DEFAULT 1,
    Popust REAL NOT NULL,
	VrijednostStavki as (Cijena * Kolicina *(1-Popust)) PERSISTED
)
-- 4. Iz baze podataka Northwind u svoju bazu podataka prebaciti sljedeće podatke:
	-- a) U tabelu Proizvodi dodati sve proizvode
		--• ProductID -> ProizvodID
		--• ProductName -> Naziv
		--• UnitPrice -> Cijena
		--• UnitsInStock -> KolicinaNaSkladistu
		--• Discontinued -> Raspolozivost
set identity_insert Prodaja.Proizvodi on
INSERT INTO Prodaja.Proizvodi (ProizvodID, Naziv, Cijena, KoliicnaNaSkladistu, Raspolozivost)
SELECT 
    ProductID,
    ProductName,
    UnitPrice,
    UnitsInStock,
    Discontinued
FROM Northwind.dbo.Products;
	-- b) U tabelu Kupci dodati sve kupce
		--• CustomerID -> KupciID
		--• CompanyName -> NazivKompanije
		--• ContactName -> Ime
		--• Phone -> Telefon
		--• Fax -> Faks
insert into Prodaja.Kupci (KupacID, NazivKompanije, Ime, Telefon, Faks)
select 
	CustomerID, CompanyName, ContactName, Phone, Fax
FROM Northwind.dbo.Customers;
	-- c) U tabelu Narudzbe dodati sve narudžbe, na mjestima gdje nema pohranjenih podataka o regiji zamijeniti vrijednost sa nije naznaceno
		--• OrderID -> NarudzbaID
		--• OrderDate -> DatumNarudzbe
		--• RequiredDate -> DatumPrijema
		--• ShippedDate -> DatumIsporuke
		--• ShipCountry -> Drzava
		--• ShipRegion -> Regija
		--• ShipCity -> Grad
		--• ShipAddress -> Adresa
set identity_insert Prodaja.Narudzbe on
insert into Prodaja.Narudzbe
    (DatumNarudzbe, DatumPrijema, DatumIsporuke, Drzava, Regija, Grad, Adresa)
SELECT 
    OrderDate,
    RequiredDate,
    ShippedDate,
    ShipCountry,
    ISNULL(ShipRegion, N'nije naznačeno') AS Regija,
    ShipCity,
    ShipAddress
FROM Northwind.dbo.Orders;
	-- d) U tabelu StavkeNarudzbe dodati sve stavke narudžbe gdje je količina veća od 4
		--• OrderID -> NarudzbaID
		--• ProductID -> ProizvodID
		--• UnitPrice -> Cijena
		--• Quantity -> Kolicina
		--• Discount -> Popust
INSERT INTO Prodaja.StavkeNarudzbe 
    (NarudzbaID, ProizvodID, Cijena, Kolicina, Popust)
SELECT 
    o.OrderID,
    o.ProductID,
    o.UnitPrice,
    o.Quantity,
    o.Discount
FROM [Northwind].[dbo].[Order Details] as o
WHERE Quantity > 4;


--NE RADI KAKO TREBA OVO ZADNJE!!!! 


-- 5. Kreirati upit kojim će se prikazati svi proizvodi čija je cijena veća od 100
GO 
use Northwind

SELECT *
FROM Products
WHERE UnitPrice >100

-- 6. Insert komandom dodati novi proizvod
INSERT INTO Products 
    (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
VALUES 
    (N'Novi Proizvod', 1, 1, N'10 kutija x 20 kom', 150.00, 50, 0, 10, 0);

-- 7. Dodati novu stavku narudžbe
INSERT INTO [Order Details]
	(OrderID, ProductID, UnitPrice, Quantity, Discount)
VALUES
	(11077, 1, 20, 5, 0)
	
-- 8. Izbrisati sve stavke narudžbe gdje je id narudžbe 10248
DELETE FROM [Order Details] WHERE OrderID = 10248
-- 9. U tabeli Proizvodi kreirati ograničenje na koloni Cijena kojim će se onemogućiti unos vrijednosti manjih od 0,1

-- 10. U tabeli proizvodi dodati izračunatu kolonu pod nazivom potrebnoNaruciti za količinu proizvoda na skladištu ispod 10 potrebno je pohraniti vrijednost „DA“ a u suptornom „NE“.
