// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.

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

int[,] SqaureEvenElements(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {
            if (matrix[i, j] % 2 == 1)
            { matrix[i, j] = matrix[i, j] * matrix[i, j]; }
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

int[,] matrix = FillArray(4, 4, 1, 10);
PrintArray(matrix);
Console.WriteLine();
int [,] matrix2 = SqaureEvenElements(matrix);
PrintArray(matrix2);