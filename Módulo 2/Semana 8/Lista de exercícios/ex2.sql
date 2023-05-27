CREATE TABLE Clientes (
id INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR(50) NOT NULL,
nascimento VARCHAR(10) NOT NULL,
email VARCHAR(50) NOT NULL,
cpf VARCHAR(50) UNIQUE NOT NULL,
senha VARCHAR(50) NOT NULL
)

CREATE TABLE Avaliacoes (
id INT PRIMARY KEY IDENTITY (1,1),
produto_id INT NOT NULL,
cliente_id INT NOT NULL,
comentario INT NOT NULL,
estrelas INT CHECK (estrelas >= 0 AND estrelas <= 5) NOT NULL ,
data_avaliacao VARCHAR(10) NOT NULL,
FOREIGN KEY(cliente_id) REFERENCES Clientes(id),
FOREIGN KEY(produto_id) REFERENCES Produtos(id)
)

CREATE TABLE Produtos (
id INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR(50) NOT NULL,
preco DECIMAL(6,2) NOT NULL,
nota int NOT NULL,
estoque INT DEFAULT 0,
vendas INT DEFAULT 0
)

CREATE TABLE Pedidos(
id INT PRIMARY KEY IDENTITY (1,1),
cliente_id INT NOT NULL,
pagamento_id INT NOT NULL,
valor INT NOT NULL,
status_pagamento BIT DEFAULT 0,
entregue BIT DEFAULT 0,
FOREIGN KEY(cliente_id) REFERENCES Clientes(id),
FOREIGN KEY(pagamento_id) REFERENCES Pagamento(id)
)


CREATE TABLE Pagamento(
id INT PRIMARY KEY IDENTITY (1,1),
cliente_id INT NOT NULL,
numeroCartao BIGINT NOT NULL,
validade VARCHAR(10) NOT NULL,
codigo INT CHECK (codigo >= 0 AND codigo <= 999),
FOREIGN KEY(cliente_id) REFERENCES Clientes(id),
)

CREATE TABLE PedidoProduto(
id INT PRIMARY KEY IDENTITY (1,1),
pedido_id INT NOT NULL,
produto_id INT NOT NULL,
FOREIGN KEY(pedido_id) REFERENCES Pedidos(id),
FOREIGN KEY(produto_id) REFERENCES Produtos(id)
)





