// Напишите программу, которая будет выдавать название
// дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Программа выдачи названия дня недели по номеру.\r\n");
Console.Write("Введите номер дня недели (целое число от 1 до 7): ");
int numberDay = Convert.ToInt32(Console.ReadLine());
switch (numberDay)
{
    case 1:
        Console.Write($"День номер {numberDay} - это понедельник");
        break;
    case 2:
        Console.Write($"День номер {numberDay} - это вторник");
        break;
    case 3:
        Console.Write($"День номер {numberDay} - это среда");
        break;
    case 4:
        Console.Write($"День номер {numberDay} - это четверг");
        break;
    case 5:
        Console.Write($"День номер {numberDay} - это пятница");
        break;
    case 6:
        Console.Write($"День номер {numberDay} - это суббота");
        break;
    case 7:
        Console.Write($"День номер {numberDay} - это воскресенье");
        break;
    default:
        Console.Write($"Ошибка!  Названия введённого номера дня не существует!");
        break;
}