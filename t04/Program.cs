using System;

namespace Sort3Project
{
    public static class Order
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Sort3(ref int a, ref int b, ref int c)
        {
            if (a > b) Swap(ref a, ref b);
            if (a > c) Swap(ref a, ref c);
            if (b > c) Swap(ref b, ref c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[][] tests = new int[][]
            {
                new int[] { 3, 1, 2 },
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 },
                new int[] { 2, 2, 1 },
                new int[] { 5, 5, 5 }
            };

            Console.WriteLine("Результаты сортировки троек чисел:");
            foreach (var t in tests)
            {
                int a = t[0];
                int b = t[1];
                int c = t[2];

                string original = $"{a} {b} {c}";
                Order.Sort3(ref a, ref b, ref c);

                string sorted = $"{a} {b} {c}";
                Console.WriteLine($"{original} -> {sorted}");
            }
        }
    }
}