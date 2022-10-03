// Задача 25: Напишите цикл, который принимает
// на вход два числа (A и B) и возводит число A
// в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Программа возведения числа в степень.\r\n");
Console.WriteLine("");

int DeegreeNumber(int number, int degree){
  int result = 1;
  for(int i=1; i <= degree; i++){
    result = result * number;
  }
    return result;
}

  Console.Write("Введите число: ");
  int number = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите степень возведения: ");
  int degree = Convert.ToInt32(Console.ReadLine());

  int exp = DeegreeNumber(number, degree);
  Console.WriteLine("Ответ: " + exp);
