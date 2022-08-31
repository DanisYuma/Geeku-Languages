// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и 
// вертикали, или напишите, что такого элемента нет.

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
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

void FindElement(int[,] matrix, int number)
{
    int element = number;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == element)
            {
                System.Console.WriteLine($"Entered number {number}. element is on [{i + 1}, {j + 1}]");
                return;                                                                                     // return выходит из функции
            }
        }
    }
    System.Console.WriteLine($"Entered number {number} is not in array");
}

int[,] matrix = FillArray(4, 4, 1, 10);
PrintArray(matrix);
int num = Prompt("Enter number> ");
FindElement(matrix, num);