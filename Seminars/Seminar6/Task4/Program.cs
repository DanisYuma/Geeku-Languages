// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

// double Factorial(int n)
// {
//     if (n == 1) return 1;      // 0! = 1, 1! = 1
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(" {0, 4}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("] -> ");
}

int[] CountFibbanachi(int Fibonacchi)
{
    int[] array = new int[Fibonacchi];
    array[0] = 0;
    array[1] = 1;
    int i = 2;
    while (i < Fibonacchi)
    {
        array[i] = array[i - 1] + array[i - 2];
        i++;
    }
    return array;
}

int number = Prompt("Введите число ");
int[] array = CountFibbanachi(number);
PrintArray(array);