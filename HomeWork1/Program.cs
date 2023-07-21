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

// Task8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count<=number) 
{
    if (count%2 == 0) Console.Write(count + " ");
    count++;
}
*/

// Два друга и собака.
// Два друга идут навстречу друг другу. Скорость первого — V1 м/с, второго — V2 м/с. У них есть собака, которая бегает со скоростью Vd м/с. 
// Когда друзья начинают свой путь, собака бежит от одного друга к другому, добегает, разворачивается и тут же бежит обратно.
// Сколько раз собака перебежит от одного друга к другому(пока расстояние между ними станет не более 10 метров), 
//пока они не встретятся, если расстояние между ними в начальный момент времени S метров?
/*
Console.Write("Enter the distance between friends: ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the speed first friend: ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the speed second friend: ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the speed dog: ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());
int count = 0;
int friend = 2;
double time = 0;
while (distance >= 10)
{
    if (friend == 1)
    {
        time = distance/(firstFriendSpeed+dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed+dogSpeed);
        friend = 1;
    }
    distance = distance-(firstFriendSpeed+secondFriendSpeed)*time;
    count++;
}
Console.WriteLine(count);
*/