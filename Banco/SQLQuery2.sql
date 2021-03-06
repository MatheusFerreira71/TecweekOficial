use bdTecweek3
create table TBEscolaridade(
Codigo int primary key not null identity(1,1),
Nome varchar(60) not null
)
create table TBParticipante(
Codigo int primary key not null identity(1,1),
CPF char(11) not null,
Nome varchar(50) not null,
DataNasc date not null,
Email varchar(60),
Telefone varchar(20),
Cod_Escolaridade int foreign key references TBEscolaridade(Codigo) not null
)
create table TBLogin(
Codigo int primary key not null identity(1,1),
Usuario varchar(50) not null, 
Cod_Aluno int foreign key references TBParticipante(Codigo) not null,
MD5 varchar(50) not null
)
create table TBPalestra(
Codigo int not null primary key identity (1,1),
Nome varchar(60) not null,
Data_Hora datetime not null, 
Max_Alunos int not null
)
create table TBCadastro_Palestra(
Codigo int not null primary key identity (1,1),
Cod_Aluno int foreign key references TBParticipante(Codigo) not null,
Cod_Palestra int foreign key references TBPalestra(Codigo) not null,
)
create table TBPresenca_Dia(
Codigo int not null primary key identity (1,1),
_Data date not null,
Cod_Aluno int foreign key references TBParticipante(Codigo) not null,
Presenca bit not null
)
create table TBPresenca_Palestra(
Codigo int not null primary key identity (1,1),
Cod_Palestra int foreign key references TBPalestra(Codigo) not null,
Cod_Aluno int foreign key references TBParticipante(Codigo) not null,
Presenca bit not null
)