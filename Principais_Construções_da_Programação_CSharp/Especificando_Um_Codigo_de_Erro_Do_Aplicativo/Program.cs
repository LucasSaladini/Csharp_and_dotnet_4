class Program
{
    // Note que estamos retornando um int, não um void
    static int Main(string[] args)
    {
        // Exiba uma mensagem e espere que a tecla Enter seja pressionada
        Console.WriteLine("***** My first C# App *****");
        Console.WriteLine("Hello World!");
        Console.WriteLine();
        Console.ReadLine();

        // Retorne um código de erro arbitrário
        return -1;
    }
}