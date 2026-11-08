using System;

namespace ArrayAlgosProject
{
    public static class ArrayAlgos
    {
        // 1. Проверка, отсортирован ли массив по возрастанию
        public static bool IsSorted(int[] a)
        {
            if (a == null || a.Length <= 1)
                return true;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                    return false;
            }

            return true;
        }

        // 2. Сортировка пузырьком на месте с флажком раннего выхода, возвращает число сравнений
        public static int BubbleSort(int[] a)
        {
            if (a == null || a.Length <= 1)
                return 0;

            int comparisons = 0;
            int n = a.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    comparisons++;
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swapped = true;
                    }
                }
                // Если на текущем проходе не было обменов, массив уже отсортирован
                if (!swapped)
                    break;
            }

            return comparisons;
        }

        // Вспомогательный метод: первый индекс элемента >= x (Lower Bound)
        private static int LowerBound(int[] a, int x)
        {
            int left = 0;
            int right = a.Length;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (a[mid] >= x)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        // Вспомогательный метод: первый индекс элемента > x (Upper Bound)
        private static int UpperBound(int[] a, int x)
        {
            int left = 0;
            int right = a.Length;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (a[mid] > x)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        // 3. Количество вхождений x через два бинарных поиска (без полного перебора)
        public static int CountOccurrences(int[] sortedA, int x)
        {
            if (sortedA == null || sortedA.Length == 0)
                return 0;

            int first = LowerBound(sortedA, x);
            
            // Если элемент вообще не найден в диапазоне массива
            if (first == sortedA.Length || sortedA[first] != x)
            {
                return 0;
            }

            int last = UpperBound(sortedA, x);

            return last - first;
        }
    }
}