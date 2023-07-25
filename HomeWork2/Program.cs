// Урок 2. Знакомство с языком программирования С#. Функции

// Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    if (num < 0) num = -num;
    return num / 10 % 10;
}

Console.Write("Input the three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = SecondDigit(number);
Console.WriteLine(digit);
*/

// Task 10(Вариант с защитой). Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    return num / 10 % 10;
}

int Numb(string messeg)
{
    Console.Write("Input the three-digit number: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    if (numb < 0) numb = -numb;
    return numb;
}

int number = Numb("Input the three-digit number: ");
while (number < 100 || number > 999) 
{
    Console.WriteLine("It's not three-digit number, repeat input number. Input number from 100 to 999 modulo");
    number = Numb("Input the three-digit number: ");
}
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

// Task 15(Вариант с защитой). Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool IsWeekend(int num)
{
    return num == 6 || num == 7;
}

int Numb(string messeg)
{
    Console.Write("Input the number of the day of the week: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

int numberDay = Numb("Input the number of the day of the week: ");
while (numberDay < 1 || numberDay > 7) 
{
    Console.WriteLine("There is no such thing for a week, repeat input of the day of the week. Input number from 1 to 7");
    numberDay = Numb("Input the number of the day of the week: ");
}
bool weekendDay = IsWeekend(numberDay);
if (weekendDay) Console.WriteLine("Yes, it's a weekend");
else Console.WriteLine("No, it's not weekend");
*/