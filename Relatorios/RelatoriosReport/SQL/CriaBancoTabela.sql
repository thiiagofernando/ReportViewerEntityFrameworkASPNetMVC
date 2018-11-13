--Cria o Banco
CREATE DATABASE PEDIDOS
--Seleciona o Banco
USE PEDIDOS

-- Cria as Tabelas

CREATE TABLE Cliente
(
     ClienteId INT PRIMARY KEY IDENTITY(1,1),
     Nome VARCHAR(200) NOT NULL
)
 
CREATE TABLE Produto
(
    ProdutoId INT PRIMARY KEY IDENTITY(1,1),
    Descricao VARCHAR(200) NOT NULL,
    Preco MONEY
)
 
CREATE TABLE Pedido
(
    PedidoId INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT,
    DataPedido DATETIME2,
)
 
CREATE TABLE ItemPedido
(
    ItemPedidoId INT PRIMARY KEY IDENTITY(1,1),
    PedidoId INT,
    ProdutoId INT,
    Quantidade DECIMAL(18,2),
    ValorTotal MONEY
)
