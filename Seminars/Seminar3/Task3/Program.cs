// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

double LineLength(int ax, int ay, int bx, int by) 
{
    return Math.Sqrt((ax-bx)*(ax-bx)+(by-ay)*(by-ay));
}

int ax = Prompt("Введите координату первой точки по x > ");
int ay = Prompt("Введите координату первой точки по y > ");
int bx = Prompt("Введите координату второй точки по x > ");
int by = Prompt("Введите координату второй точки по y > ");

double result = LineLength(ax, ay, bx, by);
System.Console.WriteLine(result);
