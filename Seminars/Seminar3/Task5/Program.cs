// 

// int Prompt(string message)
// {
//     System.Console.Write(message);          // Вывести сообщение
//     string readValue = Console.ReadLine();  //  Считывает с консоли строку
//     int result = int.Parse(readValue);      // Преобразуют строку в целое число
//     return result;                          // Возвращает результат
// }

int[] arrayFill(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(0, 101);
        i++;
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
}

int Max(int[] array)
{
    int maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    return maxNum;
}

double Average(int[] array)
{
    double sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        sum += array[i];
    }
    double avrg = sum / array.Length;
    return avrg;
}

int[] result = arrayFill(5);
printArray(result);
System.Console.WriteLine($"Max = {Max(result)}");
System.Console.WriteLine($"Среднее равно {Average(result)}");
