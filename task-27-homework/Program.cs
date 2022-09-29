// Задача 27: Напишите программу, которая
// принимает на вход число и выдаёт
// сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Программа определения суммы цифр числа.\r\n");
Console.WriteLine("");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberSumm(int number){
    
    int count = Convert.ToString(number).Length;
    int progression = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      progression = number - number % 10;
      result = result + (number - progression);
      number = number / 10;
    }
   return result;
  }

int numberSumm = NumberSumm(number);
Console.WriteLine("Сумма цифр числа: " + numberSumm);