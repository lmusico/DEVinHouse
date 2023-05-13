var lista = new List<int>();
bool maisUmElemento = true;
int maior, menor;

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

for (int i = 0; i < lista.Count; i++)
{
    for (int j = i; j < lista.Count; j++)
    {
        // Console.WriteLine($"\nValores antes da comparação:\nValor de lista {i}: {lista[i]}\nValor de lista {j}: {lista[j]}");
        while (lista[i] > lista[j])
        {
            menor = lista[j];
            maior = lista[i];
            lista[i] = menor;
            lista[j] = maior;
        }
        // Console.WriteLine($"Valores depois da comparação:\nValor de lista {i}: {lista[i]}\nValor de lista {j}: {lista[j]}");
    }

    // Console.WriteLine("\n------------------------\n", lista[i]);
}

        Console.WriteLine("\n------------------------\nFinalizado a organização da lista:");

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
