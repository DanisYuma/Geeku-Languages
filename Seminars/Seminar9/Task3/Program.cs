// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return SumDigits(number/10) + number%10;
}

int number = Prompt("Enter number> ");
int sum = SumDigits(number);
System.Console.WriteLine(sum);