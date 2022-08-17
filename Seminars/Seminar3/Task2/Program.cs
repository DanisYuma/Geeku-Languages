// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int ShowCoord(int number)
{
    if (number < 1 && number > 4)
    {
        System.Console.WriteLine("Не правильно указана четверть");
    }
    if (number == 1)
    {
       System.Console.WriteLine("X > 0 и Y > 0");
    }
    if (number == 2)
    {
        System.Console.WriteLine("X < 0 и Y > 0");
    }
    if (number == 3)
    {
        System.Console.WriteLine("X < 0 и Y < 0");
    }
    if (number == 4)
    {
        System.Console.WriteLine("X > 0 и Y < 0");
    }
    // else
    // {
    //     System.Console.WriteLine("Не правильно указана четверть");
    // }
}

int number = Prompt("Введите номер четверти > ");

int quarter = ShowCoord(number);
