﻿
// Seminar 1
//Theory
/*
int intNumber = 25;
double doubleNamber= 12.12;
string text = "some text";
bool logicVar = true;


Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your namber is " + num);
*/

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
/*
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2*num2;

if(num1 == quad2) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/

//Task 2. Напишите программу, которая на вход принимает положительное число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;
 while(current<=num)
 {
    Console.Write(current + " ");
    current++;
 }
 */
