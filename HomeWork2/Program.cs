// Урок 2. Знакомство с языком программирования С#. Функции

// Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    return num / 10 % 10;
}

Console.Write("Input the three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = SecondDigit(number);
Console.WriteLine(digit);
*/

// Task 13. Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
/*
int ThirdDigitNumber(int num)
{
    if (num < 0) num = -num;
    if (num < 100) return -1;
    else if (num > 99 && num < 1000) return num % 10;
    else 
    {   
        while (num > 1000)
        {
            num = num / 10;
        }
        return num % 10;
    }
}

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ThirdDigitNumber(number);
Console.WriteLine(thirdDigit);
*/

// Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool IsWeekend(int num)
{
    return num == 6 || num == 7;
}

Console.Write("Input the number of the day of the week: ");
int numberDay = Convert.ToInt32(Console.ReadLine());
bool weekendDay = IsWeekend(numberDay);
if (weekendDay) Console.WriteLine("Yes, it's a weekend");
else Console.WriteLine("No, it's not weekend");
*/