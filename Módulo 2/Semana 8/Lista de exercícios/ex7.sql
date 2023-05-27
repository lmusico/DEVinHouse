SELECT Clientes.nome as 'Nome do cliente', Produtos.nome, Pedidos.valor AS 'Valor total do pedido'
FROM Clientes
INNER JOIN Pedidos
ON Clientes.id = Pedidos.cliente_id
INNER JOIN PedidoProduto
on PedidoProduto.pedido_id = Pedidos.id
INNER JOIN Produtos
ON PedidoProduto.produto_id = Produtos.id
WHERE Pedidos.valor > 150