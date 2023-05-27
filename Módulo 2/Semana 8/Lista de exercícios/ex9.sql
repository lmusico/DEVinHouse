CREATE VIEW dbo.vwDetalhesPedidosCliente AS

SELECT 
Pedidos.id as 'Pedido ID', 
Clientes.nome as 'Nome do cliente', 
Clientes.email as 'Email do cliente', 
Pedidos.valor as 'Valor total', 
Pedidos.status_pagamento as 'Status do Pagamento'
FROM Clientes
INNER JOIN Pedidos 
ON Pedidos.cliente_id = Clientes.id