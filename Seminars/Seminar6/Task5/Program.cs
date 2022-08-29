// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(" {0, 4}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("] -> ");
}

int[] CopyArray(int[] array)
{
    int[] answer = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        answer[i] = array[i];
    }
    return answer;
}


int[] array = CreateArray(6, 0, 10);
PrintArray(array);
int[] array2 = CopyArray(array);
array [0] = 11;
PrintArray (array);
System.Console.WriteLine();
PrintArray (array2);