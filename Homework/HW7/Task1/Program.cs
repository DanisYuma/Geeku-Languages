// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

double[,] FillArray(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.Next(min, max + 1) * new Random().NextDouble() + min, 1);     // Задание вещественных чисел
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { Console.Write($"{matrix[i, j]} \t"); }
        Console.WriteLine();
    }
}

double[,] matrix = FillArray(3, 4, 9, 11);
PrintArray(matrix);