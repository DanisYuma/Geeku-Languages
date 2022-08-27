
string[,] table = new string[2, 5];  // Будет 2 строки - 0 и 1; и пять столбцов - 0, 1, 2, 3, 4
table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int column = 0; column < 5; column++)
//     {
//         Console.WriteLine($"-{table[rows, column]}-");
//     }
// }


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);