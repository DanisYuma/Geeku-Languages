// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    return int.Parse(Console.ReadLine());      //
}

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

void ShowElement(int[,] matrix, int i, int j)       // С точки зрения пользователя
{

    if (i > matrix.GetLength(0) || j > matrix.GetLength(1) || i < 1 || j < 1)
    { System.Console.WriteLine($"Entered position [{i}, {j}] is not in array"); }
    else
    { System.Console.WriteLine($"Entered position [{i}, {j}]. Element is {matrix[i - 1, j - 1]}"); }
}

int[,] matrix = FillArray(4, 4, 1, 100);
PrintArray(matrix);
int row = Prompt("Enter row number> ");
int column = Prompt("Enter column number> ");
ShowElement(matrix, row, column);