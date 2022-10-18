Console.Clear();

Console.WriteLine($"Пожалуйста, введите количество чисел (М): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrNum = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Пожалуйста, введите {i + 1}-е число: ");
        arrNum[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.Write("]");
}

int CountPositiveNumber(int[] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0) 
        count++;
    }
    return count;
}

InputNumbers(m);
int countPositiveNumber = CountPositiveNumber(arrNum);
PrintArray(arrNum);
Console.WriteLine($" чисел больше нуля -> {countPositiveNumber}");