// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Программа вывода чётных чисел массива.\r\n");
Console.WriteLine("");

Console.Write("Введите размер массива (size): ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100,1000); 
    Console.WriteLine($"{array[i]}");  
}


void EvenMethod(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even++;    
        }
        
    }
    Console.WriteLine($"Количество чётных чисел: {even}");
}

EvenMethod(array);
