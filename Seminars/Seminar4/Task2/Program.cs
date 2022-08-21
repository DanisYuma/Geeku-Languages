// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    return int.Parse(Console.ReadLine());      //
}


int countNumber (int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number/10;
        count++;
    }
    return count;
}

int number = Prompt("Введите число > ");
System.Console.WriteLine($"Число {number} состоит из {countNumber(number)} цифр");