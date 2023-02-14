create database gestorvacaciones


create table City (
Id  int  primary key IDENTITY(1,1),
NameCity varchar(80) not null,
)

create table Hotel (
Id  int  primary key IDENTITY(1,1),
NameHotel varchar(80) not null,
Idcity int 
FOREIGN KEY (Idcity) REFERENCES  City(Id),
)


 create table TypeBedrooms(
Id  int  primary key IDENTITY(1,1),
Name varchar(80) not null,
) 

create table Bedrooms(
Id  int  primary key IDENTITY(1,1),
Type  int ,
IdHotel int, 
NumberRooms int,
NumberPerson int,
FOREIGN KEY (Type) REFERENCES  TypeBedrooms(Id),
FOREIGN KEY (IdHotel) REFERENCES  hotel(Id),

) 

create table season (
Id  int  primary key IDENTITY(1,1),
NameSeason varchar(80) not null,
)


create table priceBedrooms(
Id  int  primary key IDENTITY(1,1),
IdBedrooms  int,
IdSeason    int ,
price  float 
FOREIGN KEY (IdBedrooms) REFERENCES  Bedrooms(Id),
FOREIGN KEY (IdSeason) REFERENCES  Season(Id),
)




