namespace _006
{
    class Program
    {
        static int[] ks(int[] c)
        {
            int[] cd = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                cd[i] = c[c.Length - i - 1];
            }
            return cd;
        }
        static void Main(string[] sa)
        {
            int[] ca = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int q = 10;
            int[] ksk = ks(ca);
            Console.WriteLine(string.Join(", ", ca));
            Console.WriteLine(string.Join(", ", ksk));
        }
    }
}