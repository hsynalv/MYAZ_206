using System;

namespace ArraysUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };

            var arr = new DataStructers.Arrays.Array(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }
    }
}
