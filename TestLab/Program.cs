﻿using System;

namespace TestLab
{
    //C# Напишите метод, который получает в качестве параметра введенное целое число большее или равное 10.
    //Метод возвращает число без его крайней левой цифры.

    public class Gay
    {
        public static int RemoveLeft(int num)
        {
            string numstr = num.ToString();
            string result1 = numstr.Substring(1);
            int result = int.Parse(result1);
            return result;
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {

        }
    }
}

//Random r = new Random();
//int input = random.Next(10, 100000);
//Console.WriteLine("Start number: " + input);
//int result = RemoveLeft(input);
//Console.WriteLine(result);




