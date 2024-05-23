using System;

class Program
{
    static void Main()
    {
        int yil = int.Parse(Console.ReadLine());
        if (yil % 4 == 0 && yil % 100 != 0 || yil % 400 == 0)
        {
            Console.WriteLine(366);
        }
        else
        {
            Console.WriteLine(365);
        }
    }
}
