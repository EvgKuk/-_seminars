// // Задача 10: Напишите программу, которая
// принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1


Console.Write("Программа для показа второй цифры 3-х значного числа.\r\n");
Console.WriteLine();
Console.Write("Введите целое трёхзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <= 999)
{
    int number1 = number/10;
    int number2 = number1 % 10;
    Console.WriteLine ($"Вторая цифра введённого числа {number2}");
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
} 
