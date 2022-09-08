// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumEven(int m, int n)
{
    if (n % 2 == 0)
    {
        if (m > n)
        {
            return 0;
        }
        return SumEven(m, n - 2) + n;
    }
    else
    {
        n = n - 1;
        if (m > n)
        {
            return 0;
        }
        return SumEven(m, n - 2) + n;
    }
}

int M = Prompt("Enter number M> ");
int N = Prompt("Enter number N> ");
int sum = SumEven(M, N);
System.Console.WriteLine(sum);
