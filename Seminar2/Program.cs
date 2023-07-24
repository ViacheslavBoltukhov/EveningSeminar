// Seminar 2

// Theory
/*
13254 // 10 = 1325
13254 // 100 = 132
13254 // 1000 = 13
13254 // 10000 = 1

13254 % 10 = 4
13254 % 100 = 54
13254 % 1000 = 254
13254 % 10000 = 3254

24365 // 100 % 100 = 43

*/

// Task1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int num)
{
    return num / 100 * 10 + num % 10;
}
 
int randNumber = new Random().Next(100,1000);
int newNamber = CutNumber(randNumber);
Console.WriteLine($"New version {randNumber} is {newNamber}");
*/

// Task2.  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
bool IsDiv(int div1, int div2, int num)
{
    return num % div1 == 0 && num % div2 == 0;
}

Console.Write("Input the number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());
bool res = IsDiv(divider1,divider2,number);
if (res) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/

// Task3. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxDigit(int num)
{
    int digit1 = num % 10;
    int digit2 = num / 10;
    if (digit1 > digit2) return digit1;
    else return digit2;   
}
int number = new Random().Next(10,100); // [a;b)
Console.WriteLine(number);
int res = MaxDigit(number);
Console.WriteLine(res);
*/

// Task4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
/*
bool SquerChech(int firstNum, int SecondNum)
{
    return (firstNum == SecondNum*SecondNum || SecondNum == firstNum*firstNum);
}

Console.Write("Input the first number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
bool res = SquerChech(numberOne, numberTwo);
if (res) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/

