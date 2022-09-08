// Проверка на простое число

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool PrimeNumber(int number, int divider)
{
    if (divider == 1)
    {
        return (true);
    }
    return PrimeNumber(number, divider -1) && (number%divider >0);
}

int number = Prompt("Enter number> ");
bool result = PrimeNumber(number, number - 1);
System.Console.WriteLine(result);
