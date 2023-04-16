internal partial class Program
{
    private static void Main(string[] args)
    {
        string frase = "A linguagem de programação C# é muito poderosa";

        List<string>palavras = new List<string>(frase.Split(" "));

        Console.WriteLine(palavras[^1]);
    }
}