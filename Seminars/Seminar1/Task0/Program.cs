// программа выдающая квадрат числа
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int value;                                  // Объявление переменной
value = Prompt("Введите значение");         // Вводим значение
int  result = value * value;                
System.Console.WriteLine($"Квадрат числа {value} равен {result}");         // Вывод результата
