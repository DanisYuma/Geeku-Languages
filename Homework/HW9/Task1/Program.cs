// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNaturalEven(int m, int n)
{
    if (n % 2 == 0)
    {
        if (m > n)
        {
            return;
        }
        ShowNaturalEven(m, n - 2);
        System.Console.WriteLine(n);
    }
    else
    {
        n = n-1;
        if (m > n)
        {
            return;
        }
        ShowNaturalEven(m, n - 2);
        System.Console.WriteLine(n);
    }
}

int M = Prompt("Enter number M> ");
int N = Prompt("Enter number N> ");
ShowNaturalEven(M, N);
