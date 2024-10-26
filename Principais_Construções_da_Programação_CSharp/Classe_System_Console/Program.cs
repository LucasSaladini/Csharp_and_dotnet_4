class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Basic Console I/O *****");
        GetUserData();
        Console.ReadLine();
    }

    static void GetUserData()
    {
        // Obtenha o nome e a idade
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.Write("Please enter your age: ");
        string userAge = Console.ReadLine();

        // Mude a cor da repetição, só por diversão
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;

        // Repita no Console
        Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

        // Retorne para a cor anterior
        Console.ForegroundColor = prevColor;
    }
}