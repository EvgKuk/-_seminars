﻿// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает его последнюю цифру.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Программа выдачи последней цифры трёхзначного числа.\r\n");
Console.Write("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = (number % 10);
Console.WriteLine($"Последняя цифра введённого числа: {lastDigit}");