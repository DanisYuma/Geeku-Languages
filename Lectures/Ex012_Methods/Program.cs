// Методы и их назначения

// Метод1
// void Method1()
// {
//     System.Console.WriteLine("Автор ...");
// }
// Method1();


// Метод2

// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2("Text");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Text", 4);
// Method21(count: 2, msg: "Text");            // Вариант написания

// Method3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// System.Console.WriteLine(year);

// Method 4

// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(4, "DY ");
// System.Console.WriteLine(res);

// Массив внутри массива (таблица умножения)

// for (int i = 2; i<10; i++)
// {
//     for (int j =2;j<=10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }

// Замена в тексте знаков. пример: к на К

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//         {
//             if (text[i] == oldValue) result += $"{newValue}";
//             else result += $"{text[i]}";
//         }

//     return result;
// }

// string  newText = Replace(text, ' ', '-');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

                                        // Сортировка

// int[] arr = { 1, 2, 5, 4, 8, 7, 6, 5, 7, 9, 4, 2, 4 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)      // (i < array.Length - 1) так как последнюю не с чем будет сравнивать
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);                    // Вызов исходного массива
// SelectionSort(arr);                 // Функция сортировки массива
// PrintArray(arr);                    // Вызов отсортированного массива

                            // ДЗ: Выполнить программу сортировки массива от большого к малому (too easy)

int[] arr = { 1, 2, 5, 4, 8, 7, 6, 5, 7, 9, 4, 2, 4 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)      // (i < array.Length - 1) так как последнюю не с чем будет сравнивать
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);                    // Вызов исходного массива
SelectionSort(arr);                 // Функция сортировки массива
PrintArray(arr);                    // Вызов отсортированного массива
