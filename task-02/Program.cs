﻿// Написать программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго:
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.Write("Программа проверки - является ли первое число квадратом второго?\r\n");

Console.Write("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
   Console.WriteLine($"число {number1} является квадратом числа {number2}");        
}
else
{
    Console.WriteLine($"число {number1} не является квадратом числа {number2}");
}

Console.Write("Проверка завершена\r\n");
