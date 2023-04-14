internal partial class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int idade;
        
        Console.WriteLine("Digite seu nome:");
        
        nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");

        idade = int.Parse(Console.ReadLine());

        if(idade >= 18){
            Console.WriteLine(nome+ ", você é maior de idade.");
            if (idade >= 60){
            Console.WriteLine("Você é considerado idoso.");
        } 
        }else {
            Console.WriteLine(nome+ ", você é menor de idade.");
        }



    }
}