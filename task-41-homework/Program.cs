// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Программа подсчёта введённых чисел больше ноля.\r\n");
Console.WriteLine("");

Console.Write("Введите целые числа, через запятую или через точку: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(',' , '.'), int.Parse);
int count = 0;

FillNumbers(array);

void FillNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
}

Console.WriteLine($"Пользователь ввёл {count} элементов больше ноля");