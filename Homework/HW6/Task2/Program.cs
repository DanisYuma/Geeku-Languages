// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

(double, double) FindIntersectionPoint(int k1, int b1, int k2, int b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

int k1 = Prompt("Enter k1> ");
int b1 = Prompt("Enter b1> ");
int k2 = Prompt("Enter k2> ");
int b2 = Prompt("Enter b2> ");

if (k1 == k2)
{
    System.Console.WriteLine("The lines coincide or are parallel");
}
else
{
System.Console.WriteLine($"{FindIntersectionPoint(k1, b1, k2, b2)}");
}