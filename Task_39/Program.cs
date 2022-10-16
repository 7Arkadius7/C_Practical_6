Console.Clear();

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

Console.WriteLine("Пожалуйста, введите длинну массива");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите минимально возможное число массива");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите максимально возможное число массива");
int maximal = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(lengthArr, minimal, maximal);
PrintArray(arr);
System.Console.WriteLine();


//________________________________________________________________________________________


// Array.Reverse(arr);
// PrintArray(arr);


//________________________________________________________________________________________

System.Console.WriteLine();

// void ReverseArray(int[] array)
// {
//     int size = array.Length;
//     int i1 = 0;
//     int i2 = size - 1;
//     while (i1 < i2)
//     {
//         int obj = array[i1];
//         array[i1] = array[i2];
//         array[i2] = obj;

//         i1++;
//         i2--;
//     }
// }




//________________________________________________________________________________________




void ReverseArray2(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size / 2; i++)
    {
        Swap(array, i, array.Length - 1 - i);
    }
}

void Swap(int[] array, int i1, int i2)
{
    int temp = array[i1];
    array[i1] = array[i2];
    array[i2] = temp;
}



//________________________________________________________________________________________


ReverseArray2(arr);
PrintArray(arr);