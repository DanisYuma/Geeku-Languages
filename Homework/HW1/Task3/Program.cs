//  Проверка четности числа

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int a;                                  // Объявление переменной
a = Prompt("Enter number> ");      // Вводим значение
if (a % 2 == 0)
{
    System.Console.WriteLine($"number {a} is even");
}
else
{
    System.Console.WriteLine($"number {a} is odd");
}