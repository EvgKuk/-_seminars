// Напишите программу, которая на вход принимает одно чило (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4-> -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 -> -2, -1, 0, 1, 2

Console.Write("Программа выдачи целых чисел в диапазоне от заданного числа до его отрицательного значения.\r\n");
Console.Write("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int numberMinus = -1;
int number2 = number1 * numberMinus;
Console.WriteLine($"Диапазон целых чисел от {number2} до {number1}: ");
for (int i = number2; i <= number1; i++)
    {
        Console.Write($" {i}");
    }
    