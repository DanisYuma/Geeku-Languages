// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  //  Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобразуют строку в целое число
    return result;                          // Возвращает результат
}

double LineLength(int ax, int ay, int bx, int by, int az, int bz) 
{
    return Math.Sqrt((bx-ax)*(bx-ax)+(by-ay)*(by-ay)+(bz-az)*(bz-az));
}

int ax = Prompt("Введите координату первой точки по x > ");
int ay = Prompt("Введите координату первой точки по y > ");
int az = Prompt("Введите координату первой точки по z> ");
int bx = Prompt("Введите координату второй точки по x > ");
int by = Prompt("Введите координату второй точки по y > ");
int bz = Prompt("Введите координату второй точки по z > ");

// int ax = new Random().Next(0, 11);
// int ay = new Random().Next(0, 11);
// int az = new Random().Next(0, 11);
// int bx = new Random().Next(0, 11);
// int by = new Random().Next(0, 11);
// int bz = new Random().Next(0, 11);

double result = LineLength(ax, ay, bx, by, az, bz);
System.Console.WriteLine(result);