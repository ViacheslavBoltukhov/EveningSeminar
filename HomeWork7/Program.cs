﻿// Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a raunding paremeter: ");
    int round_parametr = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(),round_parametr);
        }
    }
    return array;
}

void Print2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();

Print2dArray(myArray);
*/

// Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

bool IsPosition(int [,] array,int rows,int columns)
{
    return array.GetLength(0) > rows && array.GetLength(1) > columns;
}
int[,] myArray = CreateRandom2dArray();


Console.Write("Input a number rows of array: ");
int numberRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number columns of array: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());

if (IsPosition(myArray,numberRows,numberColumns)) Console.WriteLine($"array[{numberRows},{numberColumns}] = {myArray[numberRows, numberColumns]} ");
else Console.WriteLine($"Element of array[{numberRows},{numberColumns}] - not in array");
Print2dArray(myArray);
*/

// Task 51.  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return array;
}

void PrintArray(double[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Everage columns with index {i} = {array[i]} ");
    }
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] AverageColumns(int[,] array)
{
    double[] resArray = new double[array.GetLength(1)];
    double resColumnsAverage = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        for (int i = 0; i < array.GetLength(0); i++)
        {
            resColumnsAverage += array[i,j];
        }
        resArray[j] = resColumnsAverage / array.GetLength(1);
        resColumnsAverage = 0;
    }
    return resArray;
}
int[,] myArray = CreateRandom2dArray();

Print2dArray(myArray);

double[] myArrayEverageColumns = AverageColumns(myArray);

PrintArray(myArrayEverageColumns);
*/

