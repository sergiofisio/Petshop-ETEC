CREATE DATABASE IF NOT exists dbpets;
use dbpets;

create table if not exists pets (
    cod INT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    genero VARCHAR(50) NOT NULL,
    especie varCHAR(50) NOT NULL,
    raca varchar(50) NOT NULL
);

select * from pets;

SELECT MAX(cod) +1 FROM pets;

select cod as Código, nome as NOME, genero as GÊNERO, especie as ESPÉCIE, raca as RAÇA
from pets 
order by especie and raca and nome;

select especie as ESPÉCIE, COUNT(*) AS QUANTIDADE 
 from pets 
 GROUP BY especie 
 order by especie;
 
 select raca as RAÇA, COUNT(*) AS QUANTIDADE 
 from pets 
 GROUP BY raca
 order by raca;
 
 select genero as GÊNERO, COUNT(*) AS QUANTIDADE
 from pets
 GROUP BY genero;

INSERT INTO pets 
(cod, nome, genero, especie, raca)
VALUES (1, "JORGE", "MACHO", "CACHORRO", "PITBULL" );

drop table pets;
