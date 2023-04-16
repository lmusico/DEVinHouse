internal partial class Program
{
    private static void Main(string[] args)
    {
        int numero = 0;

        do{
        Console.WriteLine("Insira um número inteiro positivo:");
        
        numero = int.Parse(Console.ReadLine());
        } while (numero<=0);

        Console.WriteLine("Números pares de 0 a "+numero+":");

        for(int i = 0; i<numero; i+=2){
            Console.WriteLine(i);
        }
    }
}