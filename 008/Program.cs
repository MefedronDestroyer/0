namespace _008
{
    internal class Program
    {
        private static int[] ttt(int z, int x)
        {
            var sw = z > x ? -1 : 1;

            var cz = new int[Math.Abs(z - x) + 1];
            var c = 0;

            while (z != x + sw)
            {
                cz[c] = z;

                z += sw;
                c++;
            }

            return cz;
        }

        private static char[] ttt(char z, char x)
        {
            var cz = ttt((int)z, (int)x);

            return cz.Select(v => (char)v).ToArray();
        }
    }
}

