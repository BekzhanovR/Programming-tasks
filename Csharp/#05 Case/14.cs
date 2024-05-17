using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        float x = float.Parse(Console.ReadLine());

        float a, r1, r2, s;

        switch (n)
        {
            case 1:
                a = x;
                r1 = a * (float)Math.Sqrt(3) / 6;
                r2 = 2 * r1;
                s = a * a * (float)Math.Sqrt(3) / 4;
                Console.WriteLine(r1 + "\n" + r2 + "\n" + s);
                break;
            case 2:
                r1 = x;
                a = r1 * 6 / (float)Math.Sqrt(3);
                r2 = 2 * r1;
                s = a * a * (float)Math.Sqrt(3) / 4;
                Console.WriteLine(a + "\n" + r2 + "\n" + s);
                break;
            case 3:
                r2 = x;
                r1 = r2 / 2;
                a = r1 * 6 / (float)Math.Sqrt(3);
                s = a * a * (float)Math.Sqrt(3) / 4;
                Console.WriteLine(a + "\n" + r1 + "\n" + s);
                break;
            case 4:
                s = x;
                a = (float)Math.Sqrt(s * 4 / Math.Sqrt(3));
                r1 = a * (float)Math.Sqrt(3) / 6;
                r2 = 2 * r1;
                Console.WriteLine(a + "\n" + r1 + "\n" + r2);
                break;
            default:
                Console.WriteLine("Qate: Qayitldan kiritin");
                break;
        }
    }
}
