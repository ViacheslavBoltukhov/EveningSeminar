// HomeWork №6

// Task 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int CountZero(int m)
{
    int count = 0;
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Input numer {i+1}: ");
        int namber = Convert.ToInt32(Console.ReadLine());
        if (namber == 0) count ++;
    }
    return count;
}

Console.Write($"Input count numers: ");
int m = Convert.ToInt32(Console.ReadLine());

int zeroCount = CountZero(m);
Console.WriteLine($"Count zero: {zeroCount}");
*/

// Task 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.Write($"Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if(k1 == k2)
{
    if (b1 == b2) Console.WriteLine("line Match");
    else Console.WriteLine("Line parallel");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Point insert: ({x}; {y})");
}
*/
