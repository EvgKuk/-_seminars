// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Для создания прямоугольного массива введите целое число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m > 0)
{
    int[,] twoDimentionalArray = new int[m, m];
    
    FillArray(twoDimentionalArray);
    Console.WriteLine();

    Console.WriteLine("Исходный массив");
    PrintArray(twoDimentionalArray);
    Console.WriteLine();

    RowNumberMinSum(twoDimentionalArray);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Ошибка! Вводите только целые положительные числа.");
}



// НИЖЕ ПРОПИСАНЫ ИСПОЛЬЗОВАННЫЕ МЕТОДЫ

void FillArray(int[,] result)
{
    Random value = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i,j] = value.Next(0, 100);
        }
    }  
}
  

void PrintArray(int[,] result)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
            {
                    Console.Write($"{result[i, j]} ");
            }
        Console.WriteLine();
    }
}

void RowNumberMinSum (int[,] result)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < result.GetLength(1); i++)
    {
        minRow += result[0, i];
    }
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++) sumRow += result[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Наименьшая сумма элементов в строке {minSumRow + 1} (Сумма элементов {minRow})"); 
}

