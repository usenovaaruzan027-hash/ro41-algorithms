using System;
using System.Text;

namespace TextToolsProject
{
    public static class TextTools
    {
        // 1. Подсчет количества слов (без Regex и LINQ, учитывает пустые строки и пробелы)
        public static int CountWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            int count = 0;
            bool inWord = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]))
                {
                    if (!inWord)
                    {
                        inWord = true;
                        count++;
                    }
                }
                else
                {
                    inWord = false;
                }
            }

            return count;
        }

        // 2. Проверка на палиндром (без учета регистра и пробелов)
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // Пропускаем пробелы слева
                while (left < right && char.IsWhiteSpace(s[left]))
                {
                    left++;
                }
                // Пропускаем пробелы справа
                while (left < right && char.IsWhiteSpace(s[right]))
                {
                    right--;
                }

                // Сравниваем символы без учета регистра
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        // 3. Получение инициалов: «Ахметов Ерлан Серикұлы» → «А.Е.С.»
        public static string Initials(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            bool newWord = true;

            for (int i = 0; i < fullName.Length; i++)
            {
                char c = fullName[i];

                if (char.IsWhiteSpace(c))
                {
                    newWord = true;
                }
                else if (newWord)
                {
                    sb.Append(char.ToUpper(c)).Append('.');
                    newWord = false;
                }
            }

            return sb.ToString();
        }

        // 4. Повторение символов строки n раз через StringBuilder
        public static string Repeat(string s, int n)
        {
            if (string.IsNullOrEmpty(s) || n <= 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder(s.Length * n);

            for (int i = 0; i < n; i++)
            {
                sb.Append(s);
            }

            return sb.ToString();
        }
    }
}