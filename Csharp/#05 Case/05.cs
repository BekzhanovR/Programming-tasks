using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());

        int c = int.Parse(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine(b + c);
                break;
            case 2:
                Console.WriteLine(b - c);
                break;
            case 3:
                Console.WriteLine(b * c);
                break;
            case 4:
                if (c != 0)
                {
                    Console.WriteLine(b / c);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                break;
        }
    }
}