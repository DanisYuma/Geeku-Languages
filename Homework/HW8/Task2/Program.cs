// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintArray2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { Console.Write($"{matrix[i, j]} \t"); }
        Console.WriteLine();
    }
}

int[] SumOfRows(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    { Console.Write($"{array[i]} \t"); }
    Console.WriteLine();
}

int FindMinIndex(int[] array)
{
    int minNumber = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
            index = i;
        }
    }
    return index;
}

int[,] matrix = FillArray(4, 4, 0, 9);
PrintArray2D(matrix);
System.Console.WriteLine();
int[] sumOfRows = SumOfRows(matrix);
PrintArray(sumOfRows);
System.Console.WriteLine($"Min sum of elements is on {FindMinIndex(sumOfRows) + 1} row");