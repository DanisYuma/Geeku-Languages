//  На вход 3 числа, на выходе максимум из этих чисел

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int a;                                  // Объявление переменной
int b;
int c;
a = Prompt("Enter first number>");      // Вводим значение
b = Prompt("Enter second number>");  
c = Prompt("Enter third number>");    
int max = a;
if (b > max) max = b;
if (c > max) max = c;
{
    System.Console.WriteLine($"max = {max}");
}
