// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

// int[] array = new int[5];                   // Ручной ввод значений

int[] inputarray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i} элемент>");
    }
    return array;
}
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}
int[] array = inputarray(3);
int sum = Sum(array);
double avrg = sum / ((double)array.Length);
System.Console.WriteLine($"Сумма равна {sum}");
System.Console.WriteLine($"Средняя числа равна {avrg}");