using System;

namespace TextToolsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ТЕСТИРОВАНИЕ КЛАССА TextTools ===");
            
            // Тесты для CountWords
            Console.WriteLine("\n--- Тесты CountWords ---");
            RunWordTest("", 0);
            RunWordTest(" ", 0);
            RunWordTest(" a b ", 2);
            RunWordTest("А роза упала на лапу Азора", 6);
            RunWordTest("Ахметов Ерлан", 2);

            // Тесты для IsPalindrome
            Console.WriteLine("\n--- Тесты IsPalindrome ---");
            RunPalindromeTest("", true);
            RunPalindromeTest(" ", true);
            RunPalindromeTest(" a b ", false);
            RunPalindromeTest("А роза упала на лапу Азора", true);
            RunPalindromeTest("Ахметов Ерлан", false);

            // Тесты для Initials
            Console.WriteLine("\n--- Тесты Initials ---");
            RunInitialsTest("", "");
            RunInitialsTest(" ", "");
            RunInitialsTest("Ахметов Ерлан Серикұлы", "А.Е.С.");
            RunInitialsTest("Ахметов Ерлан", "А.Е.");

            // Тесты для Repeat
            Console.WriteLine("\n--- Тесты Repeat ---");
            RunRepeatTest("a", 3, "aaa");
            RunRepeatTest("", 5, "");
            RunRepeatTest("test", 2, "testtest");
        }

        static void RunWordTest(string input, int expected)
        {
            int actual = TextTools.CountWords(input);
            string status = (actual == expected) ? "OK" : "FAIL";
            Console.WriteLine($"Input: \"{input}\" | Expected: {expected} | Actual: {actual} | Status: {status}");
        }

        static void RunPalindromeTest(string input, bool expected)
        {
            bool actual = TextTools.IsPalindrome(input);
            string status = (actual == expected) ? "OK" : "FAIL";
            Console.WriteLine($"Input: \"{input}\" | Expected: {expected} | Actual: {actual} | Status: {status}");
        }

        static void RunInitialsTest(string input, string expected)
        {
            string actual = TextTools.Initials(input);
            string status = (actual == expected) ? "OK" : "FAIL";
            Console.WriteLine($"Input: \"{input}\" | Expected: \"{expected}\" | Actual: \"{actual}\" | Status: {status}");
        }

        static void RunRepeatTest(string input, int n, string expected)
        {
            string actual = TextTools.Repeat(input, n);
            string status = (actual == expected) ? "OK" : "FAIL";
            Console.WriteLine($"Input: \"{input}\", n={n} | Expected: \"{expected}\" | Actual: \"{actual}\" | Status: {status}");
        }
    }
}