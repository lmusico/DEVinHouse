internal partial class Program
{
    private static void Main(string[] args)
    {
        // Define the menu options
        string[] options = new string[] { "Soma (+)", "Subtração (-)", "Multiplicação (*)", "Divisão (/)", "Sair" };
        int selectedIndex = 0;
        double a = 0;
        double b = 0;
        double resultado = 0;

        while (true)
        {

            // Clear the console and display the menu options
            Console.Clear();
            Console.WriteLine("Selecione a ação desejada:");
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.Write("> ");
                }
                Console.WriteLine(options[i]);
            }

            // Read the user's input from the console
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            // Update the selected index based on the user's input
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = (selectedIndex == 0) ? options.Length - 1 : selectedIndex - 1;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = (selectedIndex == options.Length - 1) ? 0 : selectedIndex + 1;
                    break;
                case ConsoleKey.Enter:
                    Console.WriteLine("Você selecionou: " + options[selectedIndex]);
                    switch (options[selectedIndex])
                    {
                        case "Soma (+)":
                            Console.WriteLine("Entre com dois números para a operação:");
                            a = int.Parse(Console.ReadLine());
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("O resultado é: " + (a + b));
                            break;

                        case "Subtração (-)":
                            Console.WriteLine("Entre com dois números para a operação:");
                            a = int.Parse(Console.ReadLine());
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("O resultado é: " + (a - b));
                            break;

                        case "Multiplicação (*)":
                            Console.WriteLine("Entre com dois números para a operação:");
                            a = int.Parse(Console.ReadLine());
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("O resultado é: " + (a * b));
                            break;
                            
                        case "Divisão (/)":
                            Console.WriteLine("Entre com dois números para a operação:");
                            a = int.Parse(Console.ReadLine());
                            while (b == 0)
                            {
                                b = int.Parse(Console.ReadLine());
                                if (b == 0)
                                {
                                    Console.WriteLine("Não é possível dividir por zero, tente novamente:");
                                }
                            }
                            resultado = a / b;
                            Console.WriteLine("O resultado é: " + resultado);
                            break;

                    }
                    return;
            }
        }

    }
}