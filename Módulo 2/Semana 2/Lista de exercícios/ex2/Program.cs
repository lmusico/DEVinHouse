internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        
        Console.WriteLine("Entre com um número para descobrir se é par ou ímpar:");

        num = int.Parse(Console.ReadLine());

        if(num % 2 == 0){
            Console.WriteLine("O número inserido é par");
        }
        else{
            Console.WriteLine("O número inserido é ímpar");
        }


    }
}