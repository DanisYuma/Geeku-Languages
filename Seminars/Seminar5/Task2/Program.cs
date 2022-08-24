// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array)            // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

bool FindElement(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return true;
    }
    return false;
}

int[] array = CreateArray(12, -9, 9);
PrintArray(array);
int element = Prompt("Введите число> ");

if (FindElement(array, element))
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}