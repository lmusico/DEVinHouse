internal class Program
{
    private static void Main(string[] args)
    {
        string marca, modelo;
        int km;

        Console.WriteLine("Entre com a marca, modelo e quilometragem do carro:");
        marca = Console.ReadLine();
        modelo = Console.ReadLine();
        km = int.Parse(Console.ReadLine());

        Console.WriteLine(marca + ", " + modelo + ", " + km);
        if (km>10000){
            Console.WriteLine("É necessário realizar uma revisão");
        }
        
    }
}