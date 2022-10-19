// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите количество строк для массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] twoDimentionalArray = new double[m, n];
Random value = new Random();

Console.WriteLine("Введите позицию элемента");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

void FillArray(double[,] result)
{ 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
              result[i,j] = Convert.ToDouble(value.Next(-100, 100)/10.0);
            }
    }
}

void FindElement(double[,] result)
{
    if (a>m && b>n)
        Console.WriteLine("Такого элемента в массиве нет");
    else
    {
        var c = twoDimentionalArray.GetValue(a,b);
        Console.WriteLine(c);
    }
}    

FillArray(twoDimentionalArray);
Console.WriteLine();

FindElement(twoDimentionalArray);
