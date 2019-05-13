use bdTecweek;
create table TB_RA(
Cod int not null primary key identity (1,1),
RA int not null
)
create table TBCurso(
Cod int not null primary key identity (1,1),
RA varchar(30) not null
)
create table TBPeriodo(
Cod int not null primary key identity (1,1),
RA varchar(30) not null
)
create table TBSemestre(
Cod int not null primary key identity (1,1),
RA int not null
)
create table TBLogin(
Cod int not null primary key identity (1,1),
Nome varchar(60) not null,
Cod_RA int foreign key references TB_RA(Cod),
MD5 varchar(30) not null
)
create table TBAluno(
Cod int not null primary key identity (1,1),
Nome varchar(60) not null,
Cod_RA int foreign key references TB_RA(Cod),
Cod_Curso int foreign key references TBCurso(Cod),
Cod_Semestre int foreign key references TBSemestre(Cod),
Cod_Periodo int foreign key references TBPeriodo(Cod)
)
create table TBPalestra(
Cod int not null primary key identity (1,1),
Nome varchar(60) not null,
Data_Hora datetime not null, 
Max_Alunos int not null
)
create table TBCadastro_Palestra(
Cod int not null primary key identity (1,1),
Cod_RA int foreign key references TB_RA(Cod),
Cod_Palestra int foreign key references TBPalestra(Cod),
)
create table TBPresenca_Dia(
Cod int not null primary key identity (1,1),
_Data date not null,
Cod_RA int foreign key references TB_RA(Cod),
Presenca bit not null
)
create table TBPresenca_Palestra(
Cod int not null primary key identity (1,1),
Cod_Palestra int foreign key references TBPalestra(Cod),
Cod_RA int foreign key references TB_RA(Cod),
Presenca bit not null
)