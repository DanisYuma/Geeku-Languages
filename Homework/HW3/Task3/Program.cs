// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

void cubeTable(int num)
{
    for (int i =1; i <=num; i++)
    {
        int cube = i*i*i;
        System.Console.Write($"{cube}" + "\t");
    }
}

int N = Prompt("Введите N> ");
cubeTable(N);
