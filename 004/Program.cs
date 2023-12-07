namespace _004
{
    class Program
    {
        static int[] mas(char[] L, int H)
        {
            int[] Q = new int[H];
            for (int i = 0; i < H; i++)
            {
                Q[i] = (int)L[i];
            }
            return Q;
        }
        static void Main(string[] args)
        {
            char[] e = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            int[] b = mas(e, 2);
            Console.Write(e);
            Console.ReadKey();


            char[] s = { 'A', 'B', 'C', 'D', 'E' };
            int[] Q = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                Q[i] = (int)s[i];
                Console.Write(Q[i]);
            }
            Console.ReadKey();
        }
    }

}



