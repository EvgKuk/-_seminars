// Задача 36: Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Write("Программа вывода суммы элементов на нечётных позициях.\r\n");
Console.WriteLine("");

Console.Write("Введите размер массива (size): ");

int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(size); 
    Console.Write($"{array[i]} / ");
}
Console.WriteLine(""); 


void OddSumMethod(int[] array)
{
    int oddSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            oddSum += array[i];    
        }
        
    }
    Console.WriteLine($"Сумма нечётных элементов {oddSum}");
}

OddSumMethod(array);
