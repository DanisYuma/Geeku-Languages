// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int number = new Random().Next(10, 10000);       // Объявление переменной
System.Console.WriteLine(number);

// int a = number % 10;                           // Метод подбора
// int b = number / 10 % 10;
// int c = number / 100 % 10;
// int d = number / 1000 % 10;
// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// System.Console.WriteLine(max);

int max = 0;
while (number > 0)
{
    int a = number % 10;
    if (a > max) max = a;
    number = number / 10;
}
System.Console.WriteLine($"Наибольшая цифра числа равна {max}");