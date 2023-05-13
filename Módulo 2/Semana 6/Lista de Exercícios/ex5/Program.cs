var lista = new List<int>();
var listaReversa = new List<int>();
bool maisUmElemento = true;
int n1, n2;

Console.Clear();
Console.WriteLine("Entre com um número para a lista ou dê enter para finalizar:");

do
{
    try
    {
        int elemento = int.Parse(Console.ReadLine());
        lista.Add(elemento);
    }
    catch (System.Exception)
    {
        Console.WriteLine("Finalizado a inserção de itens.");

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        maisUmElemento = false;

    }

} while (maisUmElemento);

Console.WriteLine("\n---------------------\n");

for (int i = lista.Count - 1; i >= 0 ; i--)
{
    listaReversa.Add(lista[i]);
}

foreach (var item in listaReversa)
{
    Console.WriteLine(item);
}