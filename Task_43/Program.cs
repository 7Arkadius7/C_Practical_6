Console.Clear();

Console.WriteLine("Пожалуйста, введите значение b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите значение k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите значение b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите значение k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 != k2)
{
    x = (b1 - b2) / -(k1 - k2);
    y = (k2 * x) + b2;

    Console.WriteLine($"Прямые пересекаются в точке -> ({x};{y})");
}

else Console.WriteLine("Прямые параллельны");