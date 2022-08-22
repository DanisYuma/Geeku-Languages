// написать программу которая выводит последовательность цифр в таком формате 1 2 2 3 3 3 4 4 4 4

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    return int.Parse(Console.ReadLine());      //
}

void PrintNumbers(int N)
{
    int count = 0;                              // счетчик для выведенных чисел
    for (int i = 0; i <= N; i++)                
    {
        for (int j = 0; j < i; j++)
        {
            System.Console.WriteLine($"{i} ");
            count++;
            if (count == N)
            {
                return;
            }
        }
    }
}

int number = Prompt("Введите число > ");
PrintNumbers(number);