// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки
// двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк для массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для массива: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > 0 | n > 0)
{
    int[,] twoDimentionalArray = new int[m, n];
    

    FillArray(twoDimentionalArray);
    Console.WriteLine();

    Console.WriteLine("Исходный массив");
    PrintArray(twoDimentionalArray);
    Console.WriteLine();

    DecrendingSort(twoDimentionalArray);
    Console.WriteLine();

    Console.WriteLine("Массив обработанный (элементы строк по размещены по убыванию)");
    PrintArray(twoDimentionalArray);
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
        for (int j = 0; j < n; j++)
        {
            result[i,j] = value.Next(0, 100);
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

void DecrendingSort (int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1) - 1; k++)
            {
                if (result[i, k] < result[i, k + 1])
                {
                    int temp = result[i, k + 1];
                    result[i, k + 1] = result[i, k];
                    result[i, k] = temp;
                }
            }
        }
    }
}




