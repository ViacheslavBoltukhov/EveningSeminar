// HomeWork3

// Task 19. Напишите программу, которая принимает на вход натуральное число и проверяет, является ли оно палиндромом.
/*
int Revers(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res * 10 + num % 10;
        num = num / 10;
    }
    return res;
}
Console.Write("Input the natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
int reversedNamber = Revers(number);

if (number == reversedNamber) Console.WriteLine(number + " - It's palindrome");
else Console.WriteLine(number + " - It's not palindrom");
*/

// Task 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double DistanceIn3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2,2));
}

Console.Write("input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = DistanceIn3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine(distance);
*/

//Task 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    if (n <= 0) Console.WriteLine("Uncorrected number");
    else
    {
        int count = 1;
        while (count <= n)
        {
            Console.WriteLine($"{count} - {Math.Pow(count,3)}");
            count++;
        }
    }
}

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
*/
