//  Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNaturalRow (int m, int n)
{
    if (m > n)
    {
        return;
    }
    ShowNaturalRow(m, n-1);
    System.Console.WriteLine(n);
}

int M = Prompt("Enter number M> ");
int N = Prompt("Enter number N> ");
ShowNaturalRow(M, N);
