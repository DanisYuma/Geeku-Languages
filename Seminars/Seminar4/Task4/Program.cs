// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];                           // Без функции
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);             // Задание массива и печать массива в одном цикле
//     System.Console.Write($"{array[i]}" + " ");
// }

int[] generateArray(int Length)                     // Функция 
{
    int[] array = new int[Length];                  // Задание массива в функции        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void printArray (int [] array)                      // Печать массива в функции
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int [] array = generateArray(8);
printArray (array);