// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Программа проверки числа на чётность.\r\n");
Console.Write("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine($"Число {number1} - чётное");
}
else
{
    Console.WriteLine($"Число {number1} - нечётное");
}
