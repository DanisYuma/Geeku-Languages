// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] multiMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            multiMatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
                multiMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
    return multiMatrix;
}

int[,] matrix1 = FillArray(4, 4, 0, 9);
PrintArray2D(matrix1);
System.Console.WriteLine();
int[,] matrix2 = FillArray(4, 4, 0, 9);
PrintArray2D(matrix2);
System.Console.WriteLine();
int[,] multi = MatrixMultiplication(matrix1, matrix2);
PrintArray2D(multi);