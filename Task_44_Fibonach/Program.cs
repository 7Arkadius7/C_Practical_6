﻿Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int number = Convert.ToInt32(Console.ReadLine());


double Fibonachi(int n) // описываем метод поиска чисел Фибоничи
{
    if (n == 1 || n == 2) return 1;
    else if (n == 0) return 0;                 // если n(число от которого ищем число Фибоничи) равен 1 или (||) 2, то пишем на выходе 1
    else return Fibonachi(n - 1) + Fibonachi(n - 2);    // иначе делаем рекурсию метода, 
                                                        // т.е. число метод поска числа Фибоничи от (n -1) (число от которого ищем число Фибоничи) 
                                                        // складываем с методом поиска числа Фибоничи (n-2) и повторяем
                                                        // пока n == 1 (как указанно в первом условии if)
}

System.Console.WriteLine(Fibonachi(number));  // выводим метод поиска число Фибоничи (5) на экран

for (int i = 0; i < number; i++) // прописываем дополнительное условие задачи по поиску числа Фибоничи. истользуя метод,
                                 // который описывали ранее начиная с (1). Данное действие делаем через цикл, чтобы перебирали каждое число
{
    Console.Write($"{Fibonachi(i)} "); // выводим каждое значение проходящее через цикл на экран
}