using System;

namespace Learning.oop.homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольную строку");
            string str = Console.ReadLine();
            Console.WriteLine(ReverseString(str));
        }

        private static string ReverseString(string str)
        {
            string result = "";

            for(int i = 0; i < str.Length; i++)
            {
                result += str[str.Length - i - 1];
            }

            return result;
        }
    }
}
