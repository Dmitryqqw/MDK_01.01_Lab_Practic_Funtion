using System;

class Program
{
    
    static void Main()
    {
        ///задание 1
        //Console.Write("Введите натуральное число: ");
        //long number = ReadNaturalNumber();
        //long sum = SumOfDigits(number);
        //Console.WriteLine($"Сумма цифр числа {number} равна {sum}.");


        ///задание 2
        Console.Write("Введите натуральное чисилио: ");
        long number = ReadNaturalNumber();
        long reversed = ReverseNumber(number);
        PrintResult(reversed);


    }

  ///задание 1
    //static long ReadNaturalNumber()
    //{
    //    while (true)
    //    {
    //        string input = Console.ReadLine();
    //        if (TryParseNatural(input, out long value))
    //            return value;

    //        Console.Write("Некорректный ввод. Введите натуральное число: ");
    //    }
    //}

 
    //static bool TryParseNatural(string input, out long value)
    //{
    //    value = 0;
    //    if (string.IsNullOrEmpty(input)) return false;

    //    foreach (char c in input)
    //    {
    //        if (c < '0' || c > '9') return false;
    //        value = value * 10 + (c - '0');
    //    }
    //    return value > 0;
    //}


    //static long SumOfDigits(long number)
    //{
    //    long sum = 0;
    //    while (number > 0)
    //    {
    //        sum += number % 10;
    //        number /= 10;
    //    }
    //    return sum;
    //}



   ///задание 2
    static long ReadNaturalNumber()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (TryParseNatural(input, out long value))
                return value;

            Console.Write("Ты дурак ┏(-_-)┛┗(-_-﻿ )┓┗(-_-)┛┏(-_-)┓. Введите натуральное число: ");
        }
    }
    static bool TryParseNatural(string input, out long value)
    {
        value = 0;
        if (string.IsNullOrEmpty(input)) return false;

        foreach (char c in input)
        {
            if (c < '0' || c > '9') return false;
            value = value * 10 + (c - '0');
        }
        return value > 0; 
    }
    static long ReverseNumber(long number)
    {
        long reversed = 0;
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        return reversed;
    }
    static void PrintResult(long reversed)
    {
        Console.WriteLine($"Числа задым напырод : {reversed}");
    }
}

