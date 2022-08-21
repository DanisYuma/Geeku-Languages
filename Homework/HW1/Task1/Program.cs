// See сравнение двух чисел и вывод максимума и минимума

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int a;                                  // Объявление переменной
int b;
a = Prompt("Enter first number>");      // Вводим значение
b = Prompt("Enter second number>");     
if (a > b)
{
    System.Console.WriteLine($"max = {a}, min = {b}");
}
else
{
    System.Console.WriteLine($"max = {b}, min = {a}");
}
