namespace exercicio.Teste;
using exercicio;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TesteSoma()
    {
        List<double> valoresTeste = new List<double>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -5};
        double valorEsperado = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 - 5;
        double resultadoTeste = Soma.Somar(valoresTeste);
        Assert.AreEqual(valorEsperado, resultadoTeste);
    }
}