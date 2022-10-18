Console.WriteLine("Пожалуйста, введите длинну массива");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите минимально возможное число массива");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите максимально возможное число массива");
int maximal = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(lengthArr, minimal, maximal);
PrintArray(arr);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        newArray[i]=array[i];
    }
    return newArray;
}

System.Console.WriteLine();
int[] copyArray = CopyArray(arr);
PrintArray(copyArray);
