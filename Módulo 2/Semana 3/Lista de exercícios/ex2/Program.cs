internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine(Soma(3, 4));

        double resultado = Soma(3, 4, 5);

        Console.WriteLine(resultado);
    }
    private static double Soma(double num1, double num2)
    {
        return num1 + num2;
    }
    private static double Soma(double num1, double num2, double num3)
    {
        return num1 + num2 + num3;
    }
}