// HomeWork 5 

// Task 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRamdomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100,1000);
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

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }   
    return count;
}

Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(lenght);
PrintArray(myArray);

int countEverNumber = CountEvenNumbers(myArray);
Console.Write($"In array {countEverNumber} even number");
*/

// Task 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRamdomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
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

int SumNumberOddPosition(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i += 2) summa += array[i];
    return summa;
}

Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(lenght, minValue, maxValue);
PrintArray(myArray);

int summaNumberOddPosition = SumNumberOddPosition(myArray);
Console.Write($"The sum of the numbers on odd possitions: {summaNumberOddPosition}");
*/

// Task 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateArray(int size)
{   
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the array[{i}]: ");
        double ai = Convert.ToDouble(Console.ReadLine());
        array[i] = ai;
        
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.Write(array[array.Length-1] + "]");
}

double MinElemInArray(double[] array)
{
    double minElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElem) minElem = array[i];
    }
    return minElem;
}

double MaxElemInArray(double[] array)
{
    double maxElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElem) maxElem = array[i];
    }
    return maxElem;
}

Console.Write("Input lenght of the array: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input numbers of the array");
double[] myArray = CreateArray(lenght);

Console.Write("Your array: ");
PrintArray(myArray);
Console.WriteLine();

double minElemInArray = MinElemInArray(myArray);
Console.WriteLine($"Minimum elem in array: {minElemInArray}");

double maxElemInArray = MaxElemInArray(myArray);
Console.WriteLine($"Maximum elem in array: {maxElemInArray}");

double diffMaxMin = maxElemInArray - minElemInArray;
Console.WriteLine($"The difference between the maximum and minimum element in the array is {diffMaxMin}");
*/
