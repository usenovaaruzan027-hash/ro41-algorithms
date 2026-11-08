using System;

namespace ArrayAlgosProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ТЕСТИРОВАНИЕ BUBBLE SORT ===");

            int[][] testArrays = new int[][]
            {
                new int[] { },
                new int[] { 5 },
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 5, 4, 3, 2, 1 },
                new int[] { 3, 1, 3, 2, 3 }
            };

            foreach (var arr in testArrays)
            {
                int[] copy = (int[])arr.Clone();
                string before = "[" + string.Join(", ", copy) + "]";
                int comparisons = ArrayAlgos.BubbleSort(copy);
                string after = "[" + string.Join(", ", copy) + "]";
                bool sorted = ArrayAlgos.IsSorted(copy);

                Console.WriteLine($"До: {before,-15} | После: {after,-15} | IsSorted: {sorted,-5} | Сравнений: {comparisons}");
            }

            // Проверка на отсортированном массиве из 1000 элементов (ожидается 999 сравнений благодаря раннему выходу)
            int[] largeArray = new int[1000];
            for (int i = 0; i < 1000; i++) largeArray[i] = i;
            int largeComps = ArrayAlgos.BubbleSort(largeArray);
            Console.WriteLine($"\nМассив из 1000 элементов (отсортирован): число сравнений = {largeComps} (ожидается 999)");

            Console.WriteLine("\n=== ТЕСТИРОВАНИЕ COUNT OCCURRENCES ===");
            int[] sortedA = { 1, 2, 2, 2, 5, 7 };
            int[] searchValues = { 2, 1, 7, 3, 9 };
            int[] expectedCounts = { 3, 1, 1, 0, 0 };

            Console.WriteLine("Исходный отсортированный массив: [" + string.Join(", ", sortedA) + "]");
            for (int i = 0; i < searchValues.Length; i++)
            {
                int x = searchValues[i];
                int actualCount = ArrayAlgos.CountOccurrences(sortedA, x);
                string status = (actualCount == expectedCounts[i]) ? "OK" : "FAIL";
                Console.WriteLine($"x = {x} | Ожидается: {expectedCounts[i]} | Фактически: {actualCount} | Статус: {status}");
            }
        }
    }
}