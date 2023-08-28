// Task 1. Задайте двумерный массив. Напишите программу, которая поменяет местами lдве строки массива.
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

void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1 >= 0 && r1 < array.GetLength(0) 
    && r2 >= 0 && r2 < array.GetLength(0) 
    && r1 != r2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}
int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

Console.Write("Input a number one rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine()) - 1;

Console.Write("Input a number two rows: ");
int rows2 = Convert.ToInt32(Console.ReadLine()) - 1;
ChangeRows(myArray, rows1, rows2);
Print2dArray(myArray);
*/

// Task 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

void ReplacmentRowsColumns(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);
Console.WriteLine();
ReplacmentRowsColumns(myArray);
Print2dArray(myArray);
*/

// Task 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых первый расположен наименьший элемент.

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

int[] SearchPossition(int [,] array)
{   
    int [] minIndex = {0, 0};
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < array[minIndex[0],minIndex[1]])
            {
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }


    return minIndex;
}

int[,] ReplaceArray(int [,] array, int rows, int columns)
{
    int [,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for(int i = 0, n = 0; i < array.GetLength(0); i++, n++)
    {
        if(i == rows)
                {
                    n--;
                    continue;
                }
        for(int j = 0, m = 0; j < array.GetLength(1); j++, m++)
        {
            if(j != columns)
            {
                result[n,m] = array[i,j];
            }
            else 
            {
                 m--;
            }
        }
        
    }
    return result;
}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);
Console.WriteLine();

int [] indexReplace = SearchPossition(myArray);
Console.WriteLine($"{indexReplace[0]}, {indexReplace[1]}");
Console.WriteLine();

int [,] replaceMyArray =  ReplaceArray(myArray,indexReplace[0],indexReplace[1]);;
Print2dArray(replaceMyArray);
*/
