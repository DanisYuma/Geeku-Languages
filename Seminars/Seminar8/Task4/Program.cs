// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

int[] FindIndexOfMin(int[,] array)
{
    int[] minElement = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minElement[0], minElement[1]])
            {
                minElement[0] = i;
                minElement[1] = j;
            }
        }
    }
    return minElement;
}

int[,] DeleteElement(int[,] array)
{
    int[] indexes = FindIndexOfMin(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int l = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != indexes[0] && j != indexes[1])
            {
                result[k, l] = array[i, j];
                l++;
            }
        }
        if (i != indexes[0]) k++;
    }
    return result;
}

int[,] matrix = FillArray(4, 4, 0, 10);
PrintArray2D(matrix);
System.Console.WriteLine();
int[,] matrix2 = DeleteElement(matrix);
PrintArray2D(matrix2);