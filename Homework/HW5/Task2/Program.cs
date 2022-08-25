// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumEvenIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)      //Позиция нечетная относительно пользователя
    {
        sum += array[i];
    }
    return sum;
}

int[] array = CreateArray(5, 0, 10);
PrintArray(array);
int sumEven = SumEvenIndex(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях равна {sumEven} ");