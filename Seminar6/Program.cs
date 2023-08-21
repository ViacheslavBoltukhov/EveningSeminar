// Theory
/*
void ShowNum(int[] nums)
{
    nums[0] += 10;
    Console.WriteLine(nums[0]);
}
 int[] numbers = {5, 7, 8};

 ShowNum(numbers);

 Console.WriteLine(numbers[0]);
 */

// Task 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
using System.Formats.Asn1;

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

void ReversArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

}

void ReversArrayTwo(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(m, a, b);

PrintArray(myArray);

ReversArray(myArray);

PrintArray(myArray);
*/

// Task 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*
bool Tringl(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Write("Input the first line: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second line: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the third line: ");
int c = Convert.ToInt32(Console.ReadLine());

if (Tringl(a, b, c)) Console.WriteLine("YES");
else Console.WriteLine("NO");
*/

// Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

/*
void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Fibonachi(int n)
{
    int[] fib_Array = new int[n];
    fib_Array[0] = 0;
    fib_Array[1] = 1;
    for(int i = 2; i < fib_Array.Length; i++)
    {
        fib_Array[i] = fib_Array[i - 1] + fib_Array[i - 2];
    }
    return fib_Array;
}

Console.Write("Input the last elem or fibonache: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = Fibonachi(n);
PrintArray(myArray);
*/

// Task 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*
void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] CreateRamdomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}

int[] CopyArray(int size, int[] first_array)
{
    int[] second_array = new int[size];
    for(int i = 0; i < size; i++)
    {
        second_array[i] = first_array[i];
    }
    return second_array;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRamdomArray(m, a, b);
PrintArray(myArray);
int[] CopyMyArray = CopyArray(m, myArray);
PrintArray(CopyMyArray);
*/