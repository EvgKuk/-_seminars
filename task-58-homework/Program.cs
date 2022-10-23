// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет
// находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк для массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для массива: ");
int n = Convert.ToInt32(Console.ReadLine());


if (m > 0 | n > 0)
{
    int[,] twoDimentionalArrayOne = new int[m, n];
    int[,] twoDimentionalArrayTwo = new int[m, n];
    int[,] twoDimentionalArrayResult = new int[m, n];
    
    FillArray(twoDimentionalArrayOne);
    FillArray(twoDimentionalArrayTwo);
    Console.WriteLine();

    Console.WriteLine("Массив №1:");
    PrintArray(twoDimentionalArrayOne);
    Console.WriteLine();
    
    Console.WriteLine("Массив №2:");
    PrintArray(twoDimentionalArrayTwo);
    Console.WriteLine();

    if (twoDimentionalArrayOne.GetLength(0) != twoDimentionalArrayTwo.GetLength(1))
    {
        Console.WriteLine(" Невозможно перемножить ");
        return;
    }

    for (int i = 0; i < twoDimentionalArrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimentionalArrayTwo.GetLength(1); j++)
        {
            twoDimentionalArrayResult[i, j] = 0;
            for (int k = 0; k < twoDimentionalArrayOne.GetLength(1); k++)
            {
                twoDimentionalArrayResult[i, j] += twoDimentionalArrayOne[i, k] * twoDimentionalArrayTwo[k, j];
            }
            
        }
    }
PrintArray(twoDimentionalArrayResult);
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
        for (int j = 0; j < n; j++)
        {
            result[i,j] = value.Next(0, 10);
        }
    }  
}
  

void PrintArray(int[,] result)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                    Console.Write($"{result[i, j]} ");
            }
        Console.WriteLine();
    }
}