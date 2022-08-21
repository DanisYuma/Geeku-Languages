// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    return int.Parse(Console.ReadLine());      //
}

int sumSequence(int A)
{
    int answer = 0;
    for (int i = 0; i <= A; i++)
    {
        answer += i;
    }
    return answer;
}

int sumGauss (int A)
{
    int answer = (int)((A+1) * (A/2.0));
    return answer;
}

int A = Prompt("Введите число A > ");
System.Console.WriteLine($"Сумма чисел от 1 до {A} равно {sumSequence(A)}");
System.Console.WriteLine($"Сумма чисел  по Гауссу от 1 до {A} равно {sumGauss(A)}");