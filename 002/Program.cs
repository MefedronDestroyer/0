/*namespace _002
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Сумм квадратов натуральных чисел.");
            Console.WriteLine(f2(8));
        }
        static int f2(int n)
        {
            if (n <= 1) return n;
            else
            {
                int k = 0;
                for (int i = 1; i <= n; i++) k += Convert.ToInt32(Math.Pow(i, 2));
                return k;
            }
        }
    }
}*/


namespace _002
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Сумм квадратов натуральных чисел.");
            Console.WriteLine(f2(8));
        }

        static int f2(int n)
        {
            if (n <= 1)
                return n;
            else return f2(n - 1) + n * n;
        }
    }
}