// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { Console.Write($"{matrix[i, j]} \t"); }
        Console.WriteLine();
    }
}

void AvrgEachColumn(int[,] matrix)
{
    double[] averageColumn = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            averageColumn[i] += matrix[j, i];                       // Не =+ а "+=". 2 часа искал что не так
        }
        averageColumn[i] /= matrix.GetLength(0);
        System.Console.Write($"{averageColumn[i]}\t");
    }
}
int[,] matrix = FillArray(2, 4, -9, 9);
PrintArray(matrix);
System.Console.WriteLine();
AvrgEachColumn(matrix);