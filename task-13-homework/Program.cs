// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Программа для показа третьей цифры введённого числа.\r\n");
Console.WriteLine();
Console.Write("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    if (number < 1000)
    {
        int number3 = number % 10;
        Console.WriteLine ($"Третья цифра: {number3}");
    }
    else
    {
        if (number < 10000)
        {
            int number1 = number / 10;
            int number3 = number1 % 10;
            Console.WriteLine ($"Третья цифра: {number3}");
        }
        else
        {
            if (number < 100000)
            {
                int number1 = number / 100;
                int number3 = number1 % 10;
                Console.WriteLine ($"Третья цифра: {number3}");
            }
            else
            {
                if (number < 1000000)
                {
                    int number1 = number / 1000;
                    int number3 = number1 % 10;
                    Console.WriteLine ($"Третья цифра: {number3}"); 
                }
                else
                {
                    if (number < 10000000)
                    {
                        int number1 = number / 10000;
                        int number3 = number1 % 10;
                        Console.WriteLine ($"Третья цифра: {number3}");
                    }
                    else
                    {
                        if (number < 100000000)
                        {
                            int number1 = number / 100000;
                            int number3 = number1 % 10;
                            Console.WriteLine ($"Третья цифра: {number3}");  
                        }
                        else
                        {
                            if (number < 1000000000)
                            {
                                int number1 = number / 1000000;
                                int number3 = number1 % 10;
                                Console.WriteLine ($"Третья цифра: {number3}"); 
                            }
                        }
                    }
                }
            }
        }
    }
}

