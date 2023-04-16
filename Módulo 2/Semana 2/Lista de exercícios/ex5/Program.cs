internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[4];

        for(int i = 0; i<4; i++){
            Console.WriteLine("Entre com o número na posição " + i);
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);

        Console.WriteLine("\nArray números em ordem crescente:");

        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }
        
    }
}