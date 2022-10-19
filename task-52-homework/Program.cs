// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк для массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] twoDimentionalArray = new int[m, n];
Random value = new Random();

void FillArray(int[,] result)
{ 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
              result[i,j] = value.Next(0, 100);
            }
    }
}

void PrintArray(int[,] result)
{ for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                Console.Write($"{result[i, j]} ");
            }
        Console.WriteLine();
    }
}

void MiddleSumOfColumn(int[,] result)
{
    for (int j = 0; j < twoDimentionalArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < twoDimentionalArray.GetLength(0); i++)
            {
                sum += twoDimentionalArray[i, j];
            }
        Console.Write($"{ sum / twoDimentionalArray.GetLength(0)} ");
    }
}

FillArray(twoDimentionalArray);
Console.WriteLine();

PrintArray(twoDimentionalArray);
Console.WriteLine();

MiddleSumOfColumn(twoDimentionalArray);
