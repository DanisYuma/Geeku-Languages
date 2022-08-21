// показать вторую цифру трехзначного числа

int number = new Random().Next(100, 1000);       // Объявление переменной
int second = number/10 % 10;
System.Console.WriteLine(number);
System.Console.WriteLine(second);