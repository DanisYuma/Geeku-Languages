// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

int FindTwoDigits (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] < 100 && array [i] > 9)
    {
        count ++;
    }
    return count;
}

int[] array = CreateArray(12, 0, 1000);
PrintArray(array);
int twoDigits = FindTwoDigits (array);
System.Console.WriteLine($"В массиве {twoDigits} двухзначных чисел");