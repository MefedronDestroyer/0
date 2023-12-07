/*namespace _001
{
    internal class Program
    {
        static void Main() 
        { 
            Console.WriteLine("Двойной факториал числа: ");
            Console.WriteLine(f2(7));
        }
            static int f2(int o)
            { 
            int t = 1;
            for (int i = o % 2 == 0 ? 2 : 1; i <= o; i += 2) t *= i;
            return t;
            }
    }
}*/

namespace _001
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Двойной факториал числа: ");
            Console.WriteLine(f2(7));
        }
        static int f2(int q)
        {
            if (q <= 1)
                return 1;
            else return q * f2(q - 2);
        }
    }
}