class Program
{
    public static void Main(string[] args)
    {
        FormatNumericalData();
    }

    static void FormatNumericalData()
    {
        Console.WriteLine("The value 99999 in various formats:");
        Console.WriteLine("c format: {0:c}", 99999);
        Console.WriteLine("d9 format: {0:d9}", 99999);
        Console.WriteLine("f3 format: {0:f3}", 99999);
        Console.WriteLine("n format: {0:n}", 99999);

        // Note que a utilização de letras maiúsculas ou minúsculas para o
        // hexadecimal determina se as letras são maiúsculas ou minúsculas
        Console.WriteLine("E format {0:E}", 99999);
        Console.WriteLine("e format {0:e}", 99999);
        Console.WriteLine("X format {0:X}", 99999);
        Console.WriteLine("x format {0:x}", 99999);
    }
}