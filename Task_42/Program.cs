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

int binaryNumber = ConvertBinary(number);

System.Console.WriteLine($"{number} -> {binaryNumber}");