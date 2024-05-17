using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int m = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 6:
                Console.Write(n);
                break;
            case 7:
                Console.Write(n);
                break;
            case 8:
                Console.Write(n);
                break;
            case 9:
                Console.Write(9);
                break;
            case 10:
                Console.Write(10);
                break;
            case 11:
                Console.Write("Valit");
                break;
            case 12:
                Console.Write("Dama");
                break;
            case 13:
                Console.Write("Karol");
                break;
            case 14:
                Console.Write("Tuz");
                break;
        }

        switch (m)
        {
            case 1:
                Console.WriteLine("Toppon");
                break;
            case 2:
                Console.WriteLine("G'isht");
                break;
            case 3:
                Console.WriteLine("Chillik");
                break;
            case 4:
                Console.WriteLine("Qarg'a");
                break;
        }
    }
}