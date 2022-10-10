// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Программа поиска разницы макс и мин вещественного числа массива.\r\n");
Console.WriteLine("");

Console.Write("Введите размер массива (size): ");

int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

Console.Write("Введите делитель 100, 1000, 10000 и т.п.  (del): ");
int del = Convert.ToInt32(Console.ReadLine());

double minVal = Int32.MaxValue;
double maxVal = Int32.MinValue;

fillRandom(array);
minMaxDoubleMethod(array);

void fillRandom(double[] array)
{
    Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(random.Next(size)) / del; 
            Console.Write($"{array[i]} / ");
            
        }
        Console.WriteLine("");
}

void minMaxDoubleMethod(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxVal)
        {
            maxVal = array[i];
        }
        if (array[i] < minVal)
        {
            minVal = array[i];
        }
    }
Console.WriteLine($"Макс значение = {maxVal}, мин значение = {minVal}");
Console.WriteLine("");
Console.WriteLine($"Разница между макс и мин значением = {maxVal - minVal}");
}

