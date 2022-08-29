// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int[] EnterNumbers(int number)
{
    int[] numbers = new int[number];
    for (int i = 0; i < number; i++)
    {
        System.Console.Write("Enter number> ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
    return numbers;
}

int PositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void CountAndCheck(int number)
{
    if (number > 0)
    {
        int [] array = EnterNumbers(number);
        System.Console.WriteLine($"Positive numbers - {PositiveNumbers(array)}");
    }
    else
    {
        System.Console.WriteLine("The quantity of numbers cannot be less than 1");
    }
}

int value = Prompt("Enter number of numbers> ");
CountAndCheck(value);