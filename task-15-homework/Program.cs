﻿// Задача 15: Напишите программу, которая
// принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Программа определения дня недели по номеру.\r\n");
Console.WriteLine("");
Console.Write("Введите номер дня недели (целое число от 1 до 7): ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay <= 5)
{
    Console.WriteLine("Это не выходной день");
}
else
{
    Console.WriteLine("Это выходной день");
}

