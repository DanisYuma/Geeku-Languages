// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.. 

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int number = new Random().Next(10, 1000);       // Объявление переменной
System.Console.WriteLine($"{number}");
if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine($"{number} делится на 7 и 23 без остатка");
}
else
{
    System.Console.WriteLine($"{number} не делится на 7 и 23 без остатка");
}
