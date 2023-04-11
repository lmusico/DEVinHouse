internal class Program
{
    private static void Main(string[] args)
    {
        // Variáveis
        String? nome; // tipo de dado texto

        // Mensagens instrucionais ao usuário
        Console.WriteLine("Olá mundo! Digite o seu nome: ");

        // Entradas: inserção de dados
        nome = Console.ReadLine(); // Aguardando o usuário digitar

        // Saídas: mostrar resultados em tela
        Console.WriteLine("Olá " + nome + "! Sejá bem bindo ao C#!");


    }
}