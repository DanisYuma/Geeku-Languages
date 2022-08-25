// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

double[] CreateDoubleArray(int length, int min, int max)
{
    double [] answer = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = Math.Round(rnd.Next(min, max + 1) * new Random().NextDouble() + min, 1);
    }
    return answer ;
}

void PrintArray(double[] array)            // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

double FindMax (double [] array)
{
    double maxElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

double FindMin (double [] array)
{
    double minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double DifMaxMin (double max, double min)
{
    double difMaxMin = max - min;
    return difMaxMin;
}

double[] array = CreateDoubleArray(12, 0, 100);
PrintArray(array);
double max = FindMax (array);
double min = FindMin (array);
double difference = DifMaxMin (max, min);

System.Console.WriteLine($"Максимум равен - {max}, минимум равен - {min}");
System.Console.WriteLine($"а разница равна - {difference}");