use master
go
drop database if exists PigPayData
go
create database PigPayData
go
use PigPayData
go

create table BenutzerInformationen (
	UserId integer identity,
	Vorname varchar (20),
	Nachname varchar (25),
	Kontonummer int,
	Guthaben float
);

insert into BenutzerInformationen(Vorname, Nachname, Kontonummer, Guthaben) values ('Janik', 'Stucki', 1234567890, 100000)

alter table BenutzerInformationen add Passwort varchar(30);
update BenutzerInformationen set Passwort = 'Passwort' where Kontonummer = 1234567890

select * from BenutzerInformationen
Delete BenutzerInformationen Where UserId = 2;
