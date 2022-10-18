Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertBinary(int num)
{
    int binaryNum = 0;
    int count = 1;
    while (num > 0)
    {
        binaryNum = binaryNum + num % 2 * count;
        count = count * 10;
        num = num / 2;
    }
    return binaryNum;
}

void ConvertBinaryRecurtoin(int num) //метод перевод из десятичной системы в двоичную через рекурсию
{
    if (num == 0) return;
    ConvertBinaryRecurtoin(num / 2);
    Console.Write(num % 2);
}

int binaryNumber = ConvertBinary(number);
System.Console.WriteLine($"{number} -> {binaryNumber}");
System.Console.WriteLine();
ConvertBinaryRecurtoin(number);

