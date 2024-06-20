using System;

class Program
{
    static void Main()
    {
        string[] strings = { "apple", "banana", "cherry", "date" };

        Console.WriteLine("Введите строку для поиска:");
        string input = Console.ReadLine();

        bool found = false;
        foreach (string str in strings)
        {
            if (str.Equals(input))
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }
}
