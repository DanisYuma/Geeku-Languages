// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных) 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int[] generateArray(int Length)                     // Функция 
{
    int[] array = new int[Length];                  // Задание массива в функции        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void printArray(int[] array)                      // Печать массива в функции
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int SecondMax(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
        {
            max = array[i];
        }

    int second = 0;
    for (int j = 0; j < array.Length; j++)
        if (array[j] > second && array[j] < max)
        {
            second = array[j];
        }
        return second;
}

int[] array = generateArray(8);
printArray(array);
System.Console.WriteLine();
System.Console.Write($"Второе максимальное число равно {SecondMax(array)}");
