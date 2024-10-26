using System;

class Program
{
    static int Main(string[] args)
    {
        // SO método auxilir na classe Program
        ShowEnvironmentDetails();

        Console.ReadLine();
        return -1;
    }

    static void ShowEnvironmentDetails()
    {
        // Imprima os drivers nesta máquina
        // e outros detalhes interessantes
        foreach (string drive in Environment.GetLogicalDrives())
            Console.WriteLine("Drive: {0}", drive);

        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
        Console.WriteLine(".Net Version: {0}", Environment.Version);
    }
}