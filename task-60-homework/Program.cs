﻿// Задача 60. ...Сформируйте трёхмерный массив
// из неповторяющихся двузначных чисел.

// Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] threeDimentionalArray = new int[2, 2, 2];

FillArray(threeDimentionalArray);
PrintIndex(threeDimentionalArray);

void PrintIndex(int[,,] array)
{
    for (int i = 0; i < threeDimentionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDimentionalArray.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < threeDimentionalArray.GetLength(2); k++)
            {
                Console.Write($"{threeDimentionalArray[i, j, k]} ({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}
