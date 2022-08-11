// Вывод чисел в промежутке от -N до N

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int N;                                  // Объявление переменной
N = Prompt("Введите число N>");            // Вводим значение
for (int i =  -N; i<=N; i++)
{
    System.Console.WriteLine(i);
}
