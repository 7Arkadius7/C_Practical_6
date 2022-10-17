Console.WriteLine("Пожалуйста, введите стороны треугольника");
int sideA = Convert.ToInt32(Console.ReadLine());
int sideB = Convert.ToInt32(Console.ReadLine());
int sideC = Convert.ToInt32(Console.ReadLine());

if (CanTraing(sideA, sideB, sideC)) Console.WriteLine($"Да, существует");
else System.Console.WriteLine($"Нет, не существует");

bool CanTraing(int side1, int side2, int side3)
{
    return side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2;
}