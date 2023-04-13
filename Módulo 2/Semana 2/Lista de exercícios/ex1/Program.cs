internal class Program
{
    private static void Main(string[] args)
    {
        int numero1;
        int numero2;
        int soma;

        Console.WriteLine("Entre com o primeiro número da soma");

        numero1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Entre com o segundo número da soma");

        numero2 = int.Parse(Console.ReadLine());

        soma = numero1 + numero2;

        Console.WriteLine("Resultado da soma:\n" + numero1 + "+" + numero2 + "=" + soma);

    }
}