//  Определите, является ли число степенью двойки:

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsBinary(int number)
{
    if (number == 1)
    {
        return (true);
    }
        return IsBinary(number / 2) && (number % 2 == 0);
}

int number = Prompt("Enter number> ");
bool result = IsBinary(number);
System.Console.WriteLine(result);