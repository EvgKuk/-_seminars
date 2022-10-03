// Задача 23

// Напишите программу, которая принимает
// на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Программа определения значений чисел в кубе.\r\n");
Console.WriteLine("");

Console.Write("Введите целое число: ");
int nubmer = Convert.ToInt32(Console.ReadLine());

void CubeNumber (int[] nubmer)
{
    int count = 1;
    int length = nubmer.Length;
    while (count < length)
    {
        nubmer[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}

void PrintArr (int[] table)
{
    int count = table.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(table[index] + " ");
        index++;
    }
}

int[] arr = new int[nubmer + 1];
CubeNumber(arr);
PrintArr(arr);