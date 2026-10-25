using System;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.Write("Введите количество секунд (целое неотрицательное число): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int totalSeconds) || totalSeconds < 0)
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Требуется целое неотрицательное число.");
                return;
            }

            int hours = totalSeconds / 3600;
            int remainder = totalSeconds % 3600;
            int minutes = remainder / 60;
            int seconds = remainder % 60;

            Console.WriteLine($"Результат: {hours} ч. {minutes} мин. {seconds} сек.");
        }
    }
}