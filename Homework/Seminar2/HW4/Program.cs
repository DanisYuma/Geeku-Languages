// Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int dayNum = Prompt("Введите номер дня недели>");       // Объявление переменной
if (dayNum <1 || dayNum > 7)
{
    System.Console.WriteLine("Ошибка. Это не номер дня недели");
    return;
}
if (dayNum == 6 || dayNum == 7)
{
    System.Console.WriteLine("Это выходной день");
}
else
{
    System.Console.WriteLine("Это не выходной");
}
