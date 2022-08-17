// Программа выводит третью цифру, либо сообщает что ее нету
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int Get3Digit(int value)                    //  value число передаваемое функции
{
    while (value > 1000)
    {
        value = value / 10;
    }
    int third = value % 10;
    return third;                           // Возврат результата функции
}

int number = Prompt("Введите число>");      // Объявление переменной
if (number > 99)
{
    int res = Get3Digit(number);                        // в функцию Get3Digit передаем объявленную переменную. number >> value
    System.Console.WriteLine($"Третья цифра - {res}");  // Функция возвращает нам third и записывает в переменную res
}
else
{
    System.Console.WriteLine("третьей цифры нету");
}
