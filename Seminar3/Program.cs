// Seminar3

// Theory
/*
Console.WriteLine(Math.Pow(5,2)); // 5^2 = 25
Console.WriteLine(Math.Sqrt(25));
Console.WriteLine(Math.Round(Math.Sqrt(24),2));
*/
// Task 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void WriteRange(int quadrant)
{
    if (quadrant < 1 || quadrant > 4) Console.WriteLine("Uncorrect data!");
    else if (quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else Console.WriteLine("x > 0 and y < 0");
    return;
}

Console.Write("input number quadrant: ");
int quad = Convert.ToInt32(Console.ReadLine());
WriteRange(quad);
*/

//Task 2. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int Quadrant(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quad = Quadrant(x,y);
if (quad == 0) Console.WriteLine("Uncorrected data");
else Console.Write("Quadrant number is: " + quad);
*/

// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.
/*
void Squaer(int n)
{
    if (n <= 0) Console.WriteLine("Uncorrected number");
    else
    {
        int count = 1;
        while (count <= n)
        {
            Console.WriteLine($"{count} - {Math.Pow(count,2)}");
            count++;
        }
    }
}

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Squaer(num);
*/

// Task 4 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double DistanceToProgrammer(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

Console.Write("input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = DistanceToProgrammer(x1, y1, x2, y2);
Console.WriteLine(distance);
*/