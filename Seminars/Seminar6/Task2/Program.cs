// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

bool PossibleTriange (int side1, int side2, int side3)
{
    if (side1 + side2 > side3 &&
        side1 + side3 > side2 &&
        side2 + side3 > side1)
    return true;
    else
    {
        return false;
    }

}

if (PossibleTriange(Prompt("1 сторона>"), Prompt("2 сторона>"), Prompt("3 сторона>")))
{
    System.Console.WriteLine("Треугольник существует");
}
else
{
    System.Console.WriteLine("Треугольник не существует");
}
