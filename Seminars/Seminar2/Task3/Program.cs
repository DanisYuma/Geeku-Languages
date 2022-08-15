// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int number = new Random().Next(1, 10);       // Объявление переменной
int square = new Random().Next(10, 100);
System.Console.WriteLine($"{number}");
System.Console.WriteLine($"{square}");
if (square % number == 0)
{
    System.Console.WriteLine($"{square} делится на {number} без остатка");
}
else
{
    int mod = square % number;
    System.Console.WriteLine($"Остаток от деления равен {mod}");
}
