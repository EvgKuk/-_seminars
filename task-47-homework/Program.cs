// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк для массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] twoDimentionalArray = new double[m, n];
Random value = new Random();

void PrintArray(double[,] result)
{ for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                Console.Write($"{result[i, j]} ");
            }
        Console.WriteLine();
    }
}

void FillArray(double[,] result)
{ for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
              result[i,j] = Convert.ToDouble(value.Next(-100, 100)/10.0);
            }
    }
}

FillArray(twoDimentionalArray);
Console.WriteLine();

PrintArray(twoDimentionalArray);