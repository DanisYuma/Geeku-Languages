// Вывод 3 цифру из трехзначного числа

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int number = new Random().Next(10, 100);       // Объявление переменной
int a = number % 10;
int b = number/10 % 10;
int max = a;
if (b>a) max = b;
System.Console.WriteLine(number);
System.Console.WriteLine(max);