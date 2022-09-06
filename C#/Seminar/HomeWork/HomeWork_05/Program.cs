//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//Задача № 34 Решение:

/* int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 999);

    return newArray;
}

int MethodEven (int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) even++;
        else {}
    }

    return even;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);

ShowArray(myArray);

Console.Write($"Count of even numbers from random array: {MethodEven(myArray)}"); */

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Задача №36 Решение:

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue);

    return newArray;
}

int MethodOdd (int[] array)
{
    int odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0);
        else odd += array [i];
    }

    return odd;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

ShowArray(myArray);

Console.Write($"The sum of the number in odd positions: {MethodOdd(myArray)}"); */

//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//Задача №38 Решение:

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();

    return newArray;
}

double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    double difference;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else
        {
            if(array[i] < min) min = array[i];
        }
    }

    return difference = max - min;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);

ShowArray(myArray);

Console.Write($"Difference Min and Max = {FindDifference(myArray)}");