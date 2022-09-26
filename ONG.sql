CREATE DATABASE ONG;

USE ONG;


CREATE TABLE Adotante 
(
Nome varchar(30) NOT NULL,
CPF varchar(11) NOT NULL,
Data_Nascimento varchar(10) NOT NULL,
Telefone varchar(16) NULL,
CEP varchar(15) null,
RUA varchar(30) null,
Cidade varchar(40) null,
Bairro varchar(40) null,
Estado varchar(30) null,
Numero_Casa Varchar(10) null,


CONSTRAINT PK_Adontante PRIMARY KEY (CPF)
);

CREATE TABLE Animal
(
ID_chip int identity NOT NULL,
Familia varchar(40) NOT NULL,
Raca varchar(40) NOT NULL,
Sexo char(1) NOT NULL,
Nome varchar(30) NULL,
CPF varchar(11) NULL,

FOREIGN KEY(CPF) REFERENCES Adotante(CPF),
CONSTRAINT PK_Animal PRIMARY KEY (ID_chip)
);



