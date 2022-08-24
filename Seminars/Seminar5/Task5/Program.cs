// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ProductOfPairedNumbers(int[] array)
{
    int numbers = array.Length;
    int[] pairs = new int[(numbers / 2) + (numbers % 2)];
    pairs[pairs.Length - 1] = array[pairs.Length - 1];       // Присваиваем значение элемента в середине массива последнему элементу нового
    for (int i = 0; i < numbers / 2; i++)
    {
        pairs[i] = array[i] * array[array.Length - i - 1];  // Пример: [0] * [3 - 0 -1] - под индексом 2 будет третий элемент
    }
    return pairs;
}


int[] array = CreateArray(8, 0, 10);
PrintArray(array);
PrintArray(ProductOfPairedNumbers(array));