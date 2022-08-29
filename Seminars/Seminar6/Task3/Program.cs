// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int [] DecimalToBinary (int number)
{
    int [] array = new int [10];
    int i = array.Length-1;
    while (number > 0)
    {
        int bit = number % 2;
        number = number/2;
        array [i] = bit;
        i--;
    }
    return array;
}

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

int num = Prompt("Введите число> ");
int [] array = DecimalToBinary(num);
PrintArray(array);