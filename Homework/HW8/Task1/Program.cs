// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] BubbleSortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            bool flagSort = true;
            for (int j = 0; j < matrix.GetLength(0); j++)
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i,j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                    flagSort = false;
                }
            if (flagSort) { break; }
        }
    }
    return matrix;
}

int[,] matrix = FillArray(3, 4, 0, 9);
PrintArray2D(matrix);
System.Console.WriteLine();
int [,] sortedMatrix = BubbleSortRows(matrix);
PrintArray2D (sortedMatrix);