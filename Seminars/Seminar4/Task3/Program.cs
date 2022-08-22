// Напишите программу, которая принимает на вход число (N) и выдаёт произведение чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    return int.Parse(Console.ReadLine());      //
}

double Factorial(double N)
{
    double answer = 1;
    for (double i = 1; i <= N; i++)
    {
        answer = answer * i;
        System.Console.WriteLine($"Факториал {i} равен {answer}");
    }
    return answer;
}

// int sumGauss (int A)
// {
//     int answer = (int)((A+1) * (A/2.0));
//     return answer;
// }

double N = Prompt("Введите число A > ");
System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {Factorial(N)}");
// System.Console.WriteLine($"Сумма чисел  по Гауссу от 1 до {N} равно {sumGauss(N)}");