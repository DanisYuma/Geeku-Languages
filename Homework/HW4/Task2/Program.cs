// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    return int.Parse(Console.ReadLine());      //
}


int sumDigits(int num)
{
    int result = 0;
    while (num > 0)
    {
        int digit = num %10;
        result += digit;
        num = num/10;
    }
    return result;
}

int number = Prompt("Введите число > ");
System.Console.WriteLine($"сумма цифр числа {number} равно {sumDigits(number)}");