class Program
{
    static void Main(string[] args)
    {
        Console.Write("for: ");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{i}, ");
        }

        Console.WriteLine();

        Console.Write("while: ");
        int j = 0;
        while (j<10)
        {
            j++;
            Console.Write($"{j}, ");
        }

        Console.WriteLine();

        Console.WriteLine("foreach:");
        Console.Write("Wpisz tekst: "); string text = Console.ReadLine();
        int ilosc = 0;
        foreach (char x in text)
        {
            ilosc++;
        }
        Console.WriteLine($"Ilosc znakow: {ilosc}");
    }
}