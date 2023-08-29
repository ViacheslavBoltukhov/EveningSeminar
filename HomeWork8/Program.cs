// HomeWork 8
// Task 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue + 1);
    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

void SortLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
                if (array[i,k] < array[i,k + 1])
                    {
                        int temp = array[i,k];
                        array[i,k] = array[i,k + 1];
                        array[i,k + 1] = temp;
                    }
}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

Console.WriteLine();
SortLine(myArray);
Print2dArray(myArray);
*/

// Task 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue + 1);
    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

int LineMInSum(int [,] array)
{
    int result = 0;
    int sumLine = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumLine += array[i,j];
        if(sumLine < minSum || minSum == 0)
        {
            minSum = sumLine;
            result = i + 1;
        }
        sumLine = 0;
    }
    return result;
}

int[,] myArray = CreateRandom2dArray();
Print2dArray(myArray);

Console.WriteLine();
int lineMinSumElem = LineMInSum(myArray);
Console.WriteLine($"Rows number with minimum summ of elements: {lineMinSumElem}");
*/

// Task 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a rows of matrix: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of matrix: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue + 1);
    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

int[,] MultiArray(int [,] array1, int [,] array2)
{
    int [,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(1); k++)
                result [i,j] = result[i,j] + array1[i,k] * array2[k,j];
    return result;
}

Console.WriteLine("Input first matrix");
int[,] myArray1 = CreateRandom2dArray();
Print2dArray(myArray1);
Console.WriteLine();

Console.WriteLine("Input second matrix");
int[,] myArray2 = CreateRandom2dArray();
Print2dArray(myArray2);
Console.WriteLine();

Console.WriteLine("Product of fist and second matrix");
int[,] MyMultiArray = MultiArray(myArray1, myArray2);
Print2dArray(MyMultiArray);
*/

// Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
bool NumberInArray(int [,,] array, int num)
{
   for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if(num == array[i, j, k])
                    return true;
    return false;
}

int[,,] CreateRandom3dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a height of array: ");
    int height = Convert.ToInt32(Console.ReadLine());
    int number = 0;
    int[,,] array = new int[rows,columns, height];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < height; k++)
                {
                    number = new Random().Next(10,100);
                    if (NumberInArray(array, number))
                    {
                        k--;
                        continue;
                    }
                    else
                        array[i, j, k] = number;
                }
    return array;
}

void Print3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
             Console.WriteLine();
        }
}

int[,,] myArray = CreateRandom3dArray();

Print3dArray(myArray);
Console.WriteLine();
*/

// Task 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,] CreateSpiral2dArray()
{
    Console.Write("Input a rows of array: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a columns of array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int dx = 0;
    int dy = 1;
    int x = 0;
    int y = 0;
    int temp = 0;
    int nx = 0;
    int ny = 0;
    int[,] array = new int[rows,columns];

    for (int i = 1; i < rows * columns + 1; i++)
    {
        array[x, y] = i;
        if(x + dx < 0) nx = rows - Math.Abs(x + dx);
        else nx = x + dx;
        if (y + dy < 0) ny = columns - Math.Abs(y + dy);
        else ny = y + dy;
        if(array[nx % rows, ny % columns] != 0)
        {
            temp = -dx;
            dx = dy;
            dy = temp;

        }
        x = x + dx;
        y = y + dy;     
    }
    return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i,j] < 10)Console.Write($"0{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

int[,] myArray = CreateSpiral2dArray();
Print2dArray(myArray);
*/