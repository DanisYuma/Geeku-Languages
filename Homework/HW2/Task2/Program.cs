// удалить вторую цифру трехзначного числа и записать как двухзначное

int number = new Random().Next(100, 1000);       // Объявление переменной
int third = number % 10;
int second = number/10 % 10;
int first = number/100 %10;
int TwoDigit = first * 10 + third;
System.Console.WriteLine(number);
System.Console.WriteLine(TwoDigit);