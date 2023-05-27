SELECT Clientes.nome as 'Nome do cliente', Count(Avaliacoes.id) as 'Quantidade de avalia��es'
FROM Clientes
left join Avaliacoes
on Clientes.id = Avaliacoes.cliente_id
GROUP BY (Clientes.nome)