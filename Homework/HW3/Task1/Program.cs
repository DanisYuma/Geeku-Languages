// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

string Poli(int number)
{
    int fifth = number % 10;
    int fourth = number / 10 % 10;
    // int third = number/100 % 10;
    int second = number / 1000 % 10;
    int first = number / 10000 % 10;
    if (fifth == first && second == fourth)
    {
        return ($"{number} is polindrom");
    }
    else
    {
        return ($"{number} isn't polindrom");
    }
}

int num = Prompt("Введите число>");      // Объявление переменной
if (num > 9999 && num < 100000)
{
   System.Console.WriteLine(Poli(num)); 
}
else
{
    System.Console.WriteLine($"{num} isn't five digit number");
}