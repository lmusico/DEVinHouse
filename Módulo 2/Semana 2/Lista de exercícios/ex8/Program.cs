internal class Program
{
    private static void Main(string[] args)
    {
        int maior = 0;
        int leitura = 0;
        int repeticoes = 5;

        Console.WriteLine("Digite cinco números e o maior deles será retornado");
        
        for(int i = 0; i<repeticoes; i++){
            leitura = int.Parse(Console.ReadLine());
            if (leitura > maior){
                maior = leitura;
            }
        }
        Console.WriteLine("O maior número digitado foi: "+maior);
    }
}