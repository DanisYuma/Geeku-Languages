//  Вывод всех четных чисел от одного до N

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

int N = Prompt("Enter number> ");         // Вводим значение                                 
int i = 2;                              
while (i <= N)
{
    System.Console.WriteLine($"{i}");
    i = i + 2;
}
