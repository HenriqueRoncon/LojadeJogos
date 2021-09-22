CREATE DATABASE bdLojaJogos;

USE bdLojaJogos;

CREATE TABLE tbFuncionario(
FuncionarioID SMALLINT primary key,
Nome VARCHAR(150) NOT NULL,
CPF VARCHAR(14) NOT NULL,
RG VARCHAR(12) NOT NULL,
DataNasc DATE NOT NULL,
Endereco VARCHAR(150) NOT NULL,
Celular VARCHAR(15) NOT NULL,
Email VARCHAR(50) NOT NULL,
Cargo VARCHAR(50) NOT NULL
);

CREATE TABLE tbJogo(
JogoID SMALLINT PRIMARY KEY,
Nome VARCHAR(150) NOT NULL,
Versao VARCHAR(30) NOT NULL,
Desenvolvedor VARCHAR(150) NOT NULL,
Genero VARCHAR(50) NOT NULL,
FaixaEtaria INT NOT NULL,
Plataforma VARCHAR(150) NOT NULL,
AnoLanc VARCHAR(5) NOT NULL,
Sinopse VARCHAR(300) NOT NULL
);

CREATE TABLE tbCliente(
CPF VARCHAR(14) primary key,
Nome VARCHAR(150) NOT NULL,
DataNasc DATETIME NOT NULL,
Email VARCHAR(50) NOT NULL,
Celular VARCHAR(15) NOT NULL,
Endereco VARCHAR(150) NOT NULL
);

-- insert into tbFuncionario values (1, 'Pedro', '12345', '121212', '2005-07-19', 'Rua Capopemba', '11924433456', 'pedro@hotmail.com', 'Supervisor');

-- delete from tbFuncionario where FuncionarioId = 12;

-- alter table tbFuncionario modify column DataNasc DATETIME; 

-- drop database bdlojajogos;

-- select * from tbFuncionario;
-- delete from tbFuncionario where FuncionarioID = 12;

-- select * from tbCliente;
-- delete from tbCliente where CPF = '537.830.158/14';

-- select * from tbJogo;
-- delete from tbJogo where JogoID = 12;

 
  
  
   