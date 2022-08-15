// Вывод 3 цифру из трехзначного числа

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int x = Prompt("Введите число x> ");       // Объявление переменной
int a = x % 10;
System.Console.WriteLine(a);
