// Урок 1. Знакомство с языком программирования С#

// Task 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input the first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum>secondNum) Console.Write($"maximum = {firstNum}, minimum = {secondNum}");
else Console.Write($"maximum = {secondNum}, minimum = {firstNum}");
*/

// Task 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input the first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the third number: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

if (firstNum>secondNum)
{
    if (firstNum>thirdNum) Console.Write("maximum = " + firstNum);
    else Console.Write("maximum = " + thirdNum);
}
else
{
    if (secondNum>thirdNum) Console.Write("maximum = " + secondNum);
    else Console.Write("maximum = " + thirdNum);
}
*/

// Task6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0) Console.Write("Number is even");
else Console.Write("Number is not even");
*/