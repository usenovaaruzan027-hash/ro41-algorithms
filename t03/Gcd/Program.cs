using System;

namespace Gcd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Лабораторная / СРСП: Алгоритм Евклида (НОД) ===");

            RunTest(1, 48, 18, 6);
            RunTest(2, 35, 12, 1);
            RunTest(3, 100, 25, 25);
            RunTest(4, 42, 0, 42);
            RunTest(5, 0, 15, 15);
            RunTest(6, -10, 5, 0, expectError: true);
            RunTest(7, 0, 0, 0, expectError: true);

            Console.WriteLine("\nПрограмма завершена.");
        }

        static void RunTest(int testId, int a, int b, int expected, bool expectError = false)
        {
            Console.Write($"Тест #{testId} (a={a}, b={b}): ");
            try
            {
                if (a < 0 || b < 0 || (a == 0 && b == 0))
                {
                    throw new ArgumentException("Некорректный ввод: числа должны быть >= 0 и не оба равны нулю.");
                }

                while (b != 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }

                if (expectError)
                {
                    Console.WriteLine("[ОШИБКА] Ожидалось исключение, но алгоритм выполнился успешно.");
                }
                else if (a == expected)
                {
                    Console.WriteLine($"[ПРОШЕЛ] Результат = {a} (Ожидалось: {expected})");
                }
                else
                {
                    Console.WriteLine($"[ПРОВАЛЕН] Результат = {a} (Ожидалось: {expected})");
                }
            }
            catch (Exception ex)
            {
                if (expectError)
                {
                    Console.WriteLine($"[ПРОШЕЛ] Перехвачено ожидаемое исключение: {ex.Message}");
                }
                else
                {
                    Console.WriteLine($"[ОШИБКА] Исключение: {ex.Message}");
                }
            }
        }
    }
}