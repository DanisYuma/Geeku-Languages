// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n. 

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Accerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Accerman(n - 1, 1);
    else
        return Accerman(n - 1, Accerman(n, m - 1));
}

int M = Prompt("Enter number M> ");
int N = Prompt("Enter number N> ");
int accerman = Accerman(M, N);
System.Console.WriteLine(accerman);