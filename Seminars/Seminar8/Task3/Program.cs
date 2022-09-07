// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9

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
    { Console.Write($"{i} - {array[i]} \t"); }
    Console.WriteLine();
}

int[] FrequencyDictonary(int[,] array)
{
    int[] result = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[array[i, j]]++;
        }
    }
    return result;
}

int[,] matrix = FillArray(3, 4, 0, 10);
PrintArray2D(matrix);
System.Console.WriteLine();
int[] array = FrequencyDictonary(matrix);
PrintArray(array);
