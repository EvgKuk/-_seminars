// Задача 19
// Напишите программу, которая принимает
// на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Программа определения является ли введённое число палиндромом.\r\n");
Console.WriteLine("");
Console.Write("Введите число: ");
int numPal = Convert.ToInt32(Console.ReadLine());
if (numPal < 0)
{
    Console.WriteLine("Число меньше ноля");
}
int tempNumPal = numPal;
int value;
int numRev = 0;

while (tempNumPal > 0)
{
    value = tempNumPal % 10;
    numRev = numRev*10 + value;
    tempNumPal = tempNumPal / 2;
}

if (numRev == numPal)
{
    Console.WriteLine("Введённое чило палиндром");
}
else
{
Console.WriteLine("Введённое чило палиндром");
}