// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] FillArray(int rows, int columns, int randomMin, int randomMax)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(randomMin, randomMax);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { Console.Write($"{matrix[i, j]} \t"); }
        Console.WriteLine();
    }
}

int[,] matrix = FillArray(3, 4, 0, 40);
PrintArray (matrix);