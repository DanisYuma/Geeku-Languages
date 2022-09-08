// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNaturalRow (int number)
{
    if (number <= 0)
    {
        return;
    }
    ShowNaturalRow(number-1);
    System.Console.WriteLine(number);
}

int number = Prompt("Enter number> ");
ShowNaturalRow(number);