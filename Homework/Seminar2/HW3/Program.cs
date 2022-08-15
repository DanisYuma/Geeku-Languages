// Программа выводит третью цифру, либо сообщает что ее нету
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int Get3Digit(int number)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    int third = number % 10;
    return third;
}

int number = Prompt("Введите число>");       // Объявление переменной
if (number > 99)
{
    int third = Get3Digit(number);
    System.Console.WriteLine($"Третья цифра - {third}");
}
else
{
    System.Console.WriteLine("третьей цифры нету");
}
