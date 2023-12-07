namespace _010
{
    class Program
    {
        static void Text(string R, params char[] T)
        {


            for (int i = 0; i < T.Length; i++)
            {
                R += T[i].ToString();

            }
            Console.WriteLine(R);
        }
    }
}
