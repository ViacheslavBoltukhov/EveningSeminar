// Seminar 5

// Task 1. Задайте массив из m элементов, заполненный случайными числами из промежутка [a, b]. Найдите сумму отрицательных элементов массива.
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

int SumOfNegativ(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) res += array[i];
    }
    return res;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(m, a, b);

PrintArray(myArray);
Console.WriteLine(SumOfNegativ(myArray));
*/

// Task 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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

int[] MirrorDigit(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = - array[i];
    }
    return array;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(m, a, b);
PrintArray(myArray);

PrintArray(MirrorDigit(myArray));
*/

// Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

bool OnNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] == num) return true;
    }
    return false;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(m, a, b);

Console.Write("Input a search number: ");
int numberTrue = Convert.ToInt32(Console.ReadLine());

if (OnNumber(myArray, numberTrue)) Console.Write("Number is ON in array: ");
else Console.Write("Number is OFF in array: ");

PrintArray(myArray);
*/

// Task 4. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
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

int CountDigitInSection(int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] >= a && array[i] <= b) count++;
    }
    return count;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(m, a, b);

Console.Write("Input left number: ");
int leftBorder = Convert.ToInt32(Console.ReadLine());

Console.Write("Input right number: ");
int rightBorder = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CountDigitInSection(myArray, leftBorder, rightBorder));
PrintArray(myArray);
*/

// Task 5. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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

int[] ResArray(int[] array,int size)
{
    int resSize = 0;
    if (size % 2 == 0) resSize = size/2;
    else resSize = size/2 + 1;
    int[] resArray = new int[resSize];
    for (int i = 0; i < resSize; i++) 
    {
        resArray[i] = array[i]*array[size-i-1];
    }
    if (size % 2 == 0) return resArray;
    resArray[resSize-1] = array[size / 2]*array[size / 2];
    return resArray;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(m, a, b);
PrintArray(myArray);

int[] resultArray = ResArray(myArray,myArray.Length);
PrintArray(resultArray);
*/

