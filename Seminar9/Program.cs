// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

/*
string PrintNumer(int num, string res)
{
    if (num == 1)
    {
        res =  '1' + " " +  res;
        return res;
    }
    else
    {
        res =  num + " " + res;
        return PrintNumer(num - 1, res);
    }
}
string result = "";

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumer(number, result);
Console.WriteLine(result);
*/

/*
void ShowNaturalNumbers(int min, int max, int count=0)
{
    if(min>count) count=min;
    
    else count++;
    
    Console.Write(count + " ");
    
    if(count<max)
    {
        ShowNaturalNumbers(min, max, count);    
    }

}
Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(min, max);
*/


// Task 2. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(1,8));
*/


// Task 3. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
/*
int PowerAB(int a, int b)
{
    if(b == 0)
        return 1;
    return a * PowerAB(a, b - 1); 
}
Console.WriteLine(PowerAB(5,3));
*/

// Task 4. Сумма цифр числа.

/*
int SumDigits(int number)
{
    if(number == 0)
        return 0;
    else
        return number % 10 + SumDigits(number / 10);

}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));
*/
