// программа для нахождения верности квадрата числа
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int a;                                  // Объявление переменной
int b;
a = Prompt("Введите число");
b = Prompt("Введите предполагаемые квадрат числа");     // Вводим значение
if (a * a == b)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}


