// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

void SquareTable(int N)
{
    // int i = 1;
    // while (i <= N)
    for (int i = 1; i <=N; i++)
    {
        int square = i*i;
        System.Console.Write($"{square} ");
        // i++;
    }
}

int N = Prompt("Введите число N>");
SquareTable(N);