// Seminar 4

//Task 1. Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
/*
int SummaToNumber(int num)
{
    int sum = 1;
    int count = 2;
    while (num >= count)
    {
            sum = sum + count;
            count++;
    }
    return sum;
}

Console.Write("Input the number: ");
int n = Convert.ToInt32(Console.ReadLine());
int summaToNumber = SummaToNumber(n);
Console.WriteLine(summaToNumber);
*/

// Task 2. Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
/*
int CountDigit(int numb)
{
    int count = 0;
    while (numb > 0)
    {
        count++;
        numb = numb / 10;
    }
    return count;
}

Console.Write("Input the number: ");
int n = Convert.ToInt32(Console.ReadLine());
int digitCount = CountDigit(n);
Console.WriteLine(digitCount);
*/

// Task 3. Напишите программу, которая принимает на вход число N 
// и выдаёт произведение нечетных чисел от 1 до N.
/*
int ProductOdd(int num)
{
    int result = 1;
    int count = 3;
    while (num >= count)
    {
            result = result * count;
            count = count + 2;
    }
    return result;
}

Console.Write("Input the number: ");
int n = Convert.ToInt32(Console.ReadLine());
int oddProduct = ProductOdd(n);
Console.WriteLine(oddProduct);
*/

// Task 4. Генерация массива с клавиатуры
/*
int[] CreateRamdomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}
void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Input lenght of the array: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possibal value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possibal value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRamdomArray(lenght,min,max);
PrintArray(array);
*/
