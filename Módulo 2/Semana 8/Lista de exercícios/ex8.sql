CREATE OR ALTER PROCEDURE AtualizarEstoque
@idProduto INT, @qtdVendas INT
AS
UPDATE Produtos SET estoque = estoque - @qtdVendas
where id = @idProduto
UPDATE Produtos SET vendas = vendas + @qtdVendas
where id = @idProduto
