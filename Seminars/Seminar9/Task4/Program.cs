// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    return a * Power(a, b - 1);
}

int a = Prompt("Enter number A> ");
int b = Prompt("Enter number B> ");
System.Console.WriteLine(Power(a, b));
