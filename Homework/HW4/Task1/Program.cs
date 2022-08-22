// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    return int.Parse(Console.ReadLine());      //
}


int Sqaring(int number, int multiply)
{
int result = 1;
    for (int i = 0; i < multiply; i++)
    {
        result = result * number;
    }
    return result;
}

int A = Prompt("Введите A > ");
int B = Prompt("Введите B > ");
System.Console.WriteLine($"{A} в степени {B} равно {Sqaring(A, B)}");
