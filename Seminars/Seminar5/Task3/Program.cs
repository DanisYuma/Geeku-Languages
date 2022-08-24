// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

void PrintArray(int[] array)            // вывод массива на консоль
{
for (int j = 0; j < array.Length; j++)
{
Console.Write(array[j] + "\t");
}
System.Console.WriteLine();
}

int [] ChangeSign (int [] reverse)
{
    for (int i = 0; i < reverse.Length; i++)
    {
        reverse [i] = - reverse [i];
    }
    return reverse;
}

int [] array = CreateArray(12, -9, 9);
PrintArray(array);
PrintArray(ChangeSign(array));