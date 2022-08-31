// Задайте двумерный массив. Найдите сумму элементов главной диагонали.

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

int SumDiagonalElements (int [,] matrix)
{   
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        if (i == j) { sum += matrix [i,j]; }
    }
    return sum;
}

int[,] matrix = FillArray(4, 4, 1, 10);
PrintArray(matrix);
Console.WriteLine();
System.Console.WriteLine($"sum of diagonal numbers is {SumDiagonalElements(matrix)} ");