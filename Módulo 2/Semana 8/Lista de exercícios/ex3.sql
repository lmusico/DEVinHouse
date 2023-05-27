
-- Inserção de linhas na tabela Avaliacoes
INSERT INTO Avaliacoes (produto_id, cliente_id, comentario, estrelas, data_avaliacao)
VALUES
    (1, 1, 'Ótimo produto!', 5, 20230527),
    (1, 2, 'Gostei bastante!', 4, 20230526),
    (2, 3, 'Poderia ser melhor.', 3, 20230525),
    (2, 4, 'Produto de qualidade!', 5, 20230524),
    (3, 5, 'Recomendo a todos!', 5, 20230523),
    (3, 6, 'Entrega rápida.', 4, 20230522),
    (4, 7, 'Excelente atendimento.', 5, 20230521),
    (4, 8, 'Preço acessível.', 4, 20230520),
    (5, 9, 'Bom custo-benefício.', 3, 20230519),
    (5, 10, 'Ótima opção.', 5, 20230518);


-- Inserção de linhas na tabela Pedidos
INSERT INTO Pedidos (cliente_id, pagamento_id, valor, status_pagamento, entregue)
VALUES
    (1, 1, 50, 1, 1),
    (2, 2, 30, 0, 0),
    (3, 3, 40, 1, 0),
    (4, 4, 20, 0, 1),
    (5, 5, 60, 1, 1),
    (6, 6, 35, 0, 0),
    (7, 7, 45, 1, 0),
    (8, 8, 25, 0, 1),
    (9, 9, 55, 1, 1),
    (10, 10, 30, 0, 0);

-- Inserção de linhas na tabela Pagamento
INSERT INTO Pagamento (cliente_id, numeroCartao, validade, codigo)
VALUES
    (1, 1234567890123456, '2025-12-31', 123),
    (2, 9876543210987654, '2024-09-30', 456),
    (3, 4567891230456789, '2023-06-30', 789),
    (4, 3216549870321654, '2022-03-31', 012),
    (5, 6549873210654987, '2026-02-28', 345),
    (6, 7891234560789123, '2025-11-30', 678),
    (7, 0123456789012345, '2024-08-31', 901),
    (8, 9876543210987654, '2023-05-31', 234),
    (9, 3216549870321654, '2022-02-28', 567),
    (10, 6549873210654987, '2026-01-31', 890);

-- Inserção de linhas na tabela PedidoProduto
INSERT INTO PedidoProduto (pedido_id, produto_id)
VALUES
    (1, 1),
    (1, 2),
    (2, 3),
    (2, 4),
    (3, 5),
    (3, 6),
    (4, 7),
    (4, 8),
    (5, 9),
    (5, 10);


SELECT * FROM Avaliacoes
-- Inserção de linhas na tabela Clientes
INSERT INTO Clientes (nome, nascimento, email, cpf, senha)
VALUES 
    ('João', '1990-05-15', 'joao@email.com', '12345678901', 'senha123'),
    ('Maria', '1985-09-20', 'maria@email.com', '98765432101', 'senha456'),
    ('Carlos', '1992-02-10', 'carlos@email.com', '45678912301', 'senha789'),
    ('Ana', '1988-12-05', 'ana@email.com', '32165498701', 'senha012'),
    ('Pedro', '1995-07-25', 'pedro@email.com', '65498732101', 'senha345'),
    ('Sandra', '1993-04-18', 'sandra@email.com', '78912345601', 'senha678'),
    ('Rafael', '1991-08-30', 'rafael@email.com', '01234567891', 'senha901'),
    ('Camila', '1994-06-12', 'camila@email.com', '98765432109', 'senha234'),
    ('Fernanda', '1987-03-08', 'fernanda@email.com', '32165498709', 'senha567'),
    ('Lucas', '1996-11-02', 'lucas@email.com', '65498732109', 'senha890');

-- Inserção de linhas na tabela Avaliacoes
INSERT INTO Avaliacoes (produto_id, cliente_id, comentario, estrelas, data_avaliacao)
VALUES
    (1, 1, 'Ótimo produto!', 5, 20230527),
    (1, 2, 'Gostei bastante!', 4, 20230526),
    (2, 3, 'Poderia ser melhor.', 3, 20230525),
    (2, 4, 'Produto de qualidade!', 5, 20230524),
    (3, 5, 'Recomendo a todos!', 5, 20230523),
    (3, 6, 'Entrega rápida.', 4, 20230522),
    (4, 7, 'Excelente atendimento.', 5, 20230521),
    (4, 8, 'Preço acessível.', 4, 20230520),
    (5, 9, 'Bom custo-benefício.', 3, 20230519),
    (5, 10, 'Ótima opção.', 5, 20230518);

-- Inserção de linhas na tabela Produtos
INSERT INTO Produtos (nome, preco, nota, estoque, vendas)
VALUES
    ('Produto A', 10.99, 4, 50, 100),
    ('Produto B', 19.99, 3, 20, 50),
    ('Produto C', 8.99, 5, 100, 200),
    ('Produto D', 14.99, 4, 30, 80),
    ('Produto E', 12.99, 5, 40, 120),
    ('Produto F', 9.99, 3, 60, 150),
    ('Produto G', 11.99, 4, 25, 70),
    ('Produto H', 18.99, 5, 35, 90),
    ('Produto I', 7.99, 3, 80, 180),
    ('Produto J', 13.99, 5, 15, 60);

-- Inserção de linhas na tabela Pedidos
INSERT INTO Pedidos (cliente_id, pagamento_id, valor, status_pagamento, entregue)
VALUES
    (1, 1, 50, 1, 1),
    (2, 2, 30, 0, 0),
    (3, 3, 40, 1, 0),
    (4, 4, 20, 0, 1),
    (5, 5, 60, 1, 1),
    (6, 6, 35, 0, 0),
    (7, 7, 45, 1, 0),
    (8, 8, 25, 0, 1),
    (9, 9, 55, 1, 1),
    (10, 10, 30, 0, 0);

-- Inserção de linhas na tabela Pagamento
INSERT INTO Pagamento (cliente_id, numeroCartao, validade, codigo)
VALUES
    (1, 1234567890123456, '2025-12-31', 123),
    (2, 9876543210987654, '2024-09-30', 456),
    (3, 4567891230456789, '2023-06-30', 789),
    (4, 3216549870321654, '2022-03-31', 012),
    (5, 6549873210654987, '2026-02-28', 345),
    (6, 7891234560789123, '2025-11-30', 678),
    (7, 0123456789012345, '2024-08-31', 901),
    (8, 9876543210987654, '2023-05-31', 234),
    (9, 3216549870321654, '2022-02-28', 567),
    (10, 6549873210654987, '2026-01-31', 890);

-- Inserção de linhas na tabela PedidoProduto
INSERT INTO PedidoProduto (pedido_id, produto_id)
VALUES
    (1, 1),
    (1, 2),
    (2, 3),
    (2, 4),
    (3, 5),
    (3, 6),
    (4, 7),
    (4, 8),
    (5, 9),
    (5, 10);
