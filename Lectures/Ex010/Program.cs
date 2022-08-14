int[] array = {12,4,54,58,32,47,94,12,10,54};

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;                      // Оператор для прерывания операции
    }
    index++;
}