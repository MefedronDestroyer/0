using System;
namespace _003
{
    class Program 
    {
        static S[] qe<S>(S[] fa, int n) => fa.Take(n).ToArray();
        static void Main(string[] args) 
        {
            var q1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var q2 = new char[] { 'x', 'y', 'z', 'q' }; 
            var q3 = qe(q1, 7); 
            Console.WriteLine(string.Join(" ", q3)); 
            var q4 = qe(q2, 3); 
            Console.WriteLine(string.Join(" ", q4)); 
        } 
    } 
}