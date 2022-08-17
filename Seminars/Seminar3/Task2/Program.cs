// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

string ShowCoord(int number)
{
    if (number == 1)
    {
        return ("X > 0 и Y > 0");
    }
    if (number == 2)
    {
        return ("X < 0 и Y > 0");
    }
    if (number == 3)
    {
        return ("X < 0 и Y < 0");
    }
    if (number == 4)
    {
        return ("X > 0 и Y < 0");
    }
    return ("Не правильно указана четверть");
}

int number = Prompt("Введите номер четверти > ");
System.Console.WriteLine(ShowCoord(number));
// string quarter = ShowCoord(number);
