internal class Program
{
    private static void Main(string[] args)
    {
        int quantidade;
        double soma = 0;
        int[] numeros;
        
        Console.WriteLine("Quantos números deseja calcular a média aritimética?");
        
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com os "+ quantidade + " números desejados:");

        numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        foreach (var item in numeros)
        {
            soma += item;
        }

        Console.WriteLine("A média " + soma + "/" + quantidade + " é: " + (soma/quantidade));

    }
}