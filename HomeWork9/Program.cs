// Task 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
string PrintNumbers(int end)
{
    if (end == 1) return end.ToString();
    return (end + " " + PrintNumbers(end - 1));
}

Console.Write("Input the last number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(n));
*/

// Task 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

/*
int SumNumbers(int start, int end)
{
    if (start > end) return 0;
    return start + SumNumbers(start + 1, end);
}

Console.Write("Input the first number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the last number: ");
int last = Convert.ToInt32(Console.ReadLine());

if (first > last)
{
    int temp = first;
    first = last;
    last = temp;
}
Console.WriteLine(SumNumbers(first, last));
*/

// Task 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int Akerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m > 0)
        return Akerman(m - 1, 1);
    else
        return (Akerman(m - 1, Akerman(m, n - 1)));
}

Console.Write("Input the m parameter: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the n parameter: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akerman(m, n));
*/