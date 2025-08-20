-- CRIANDO O BANCO DE DADOS
CREATE DATABASE BDProjeto1;
-- USANDO O BANCO DE DADOS
USE BDProjeto1;
-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE tbLogin(
	codLogin int primary key auto_increment,
	usuario varchar(40),
	senha varchar(40)
);
-- CONSULTANDO AS TABELAS DO BANCO
SELECT*FROM tbLogin
