// Найти максимальное  значение в каждой строке, суммируйте их
// Найти минимальное значение в каждой колонке, суммируйте их
// Найти разницу между суммами

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    { Console.Write($"{array[i]} \t"); }
    Console.WriteLine();
}

int[] MaxValueInRows(int[,] matrix)
{
    int[] maxValuesInRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        maxValuesInRows[i] = int.MinValue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > maxValuesInRows[i])
                maxValuesInRows[i] = matrix[i, j];
        }
    }
    return maxValuesInRows;
}

int[] MinValueInColumns(int[,] matrix)
{
    int[] minValuesInColumns = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minValuesInColumns[j] = int.MaxValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[j, i] < minValuesInColumns[j])
                minValuesInColumns[j] = matrix[j, i];
        }
    }
    return minValuesInColumns;
}

int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

int[,] matrix = FillArray(3, 4, 0, 9);
PrintArray2D(matrix);
System.Console.WriteLine();
MaxValueInRows(matrix);
PrintArray(MaxValueInRows(matrix));
MinValueInColumns(matrix);
PrintArray(MinValueInColumns(matrix));
System.Console.WriteLine($"{SumArray(MaxValueInRows(matrix))}");
System.Console.WriteLine($"{SumArray(MinValueInColumns(matrix))}");