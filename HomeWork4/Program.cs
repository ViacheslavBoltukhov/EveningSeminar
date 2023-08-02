// HomeWork 4.

// Task 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Power(double a, int b)
{
    double res = 1;
    for ( int i = 0; i < b; i++) res = res * a;
    return res;
}

Console.Write("Input the number: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.Write("Input the power: ");
int power = Convert.ToInt32(Console.ReadLine());

double numberInPower = Power(number,power);
Console.WriteLine($"{number}^{power} = {numberInPower}");
*/

// Task 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigitNumber(int num)
{
    int res = 0;
    while ( num != 0 )
    {
        res += num%10;
        num /= 10;
    }
    return res;
}

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigitNumber = SumDigitNumber(number);
Console.WriteLine($"Sum digits of number {number} is equal to {sumDigitNumber}");
*/

// Task 29. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{   
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the array[{i}]: ");
        int ai = Convert.ToInt32(Console.ReadLine());
        array[i] = ai;
        
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input lenght of the array: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input digits of the array");
int[] array = CreateArray(lenght);

Console.WriteLine("Your array");
PrintArray(array);
*/

