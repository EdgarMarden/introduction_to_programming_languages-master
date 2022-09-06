//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];
    
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) sum += array[i];
    
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

ShowArray(myArray);

int positiveSum = FindPositiveSum(myArray);
int negativeSum = FindNegativeSum(myArray);

Console.WriteLine($"Sum of positive elemetns is {positiveSum} \nSum of negative elements is {negativeSum}"); */

//Напишите программу замена элементов массива:
//положительные элементы замените на
//соответствующие отрицательные, и наоборот.

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}

void ReplacePositiveElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) array[i] *= -1;
}

void ReplaceNegativeElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) array[i] *= -1;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

ReplacePositiveElements(myArray);
Console.WriteLine($"Array from Replace Positive Elements: ");
ShowArray(myArray);

ReplaceNegativeElements(myArray);
Console.WriteLine($"Array from Replace Negative Elements: ");
ShowArray(myArray); */

//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве.

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

bool FindMathces(int[] array)
{   
    Console.Write("Input any Number for find from array: ");
    int findValue = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < array.Length; i++)
    {
        if(findValue == array[i])

            return true;
    }

    return false;
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

Console.WriteLine($"{FindMathces(myArray)}"); */

//Задайте одномерный массив из 12 случайных чисел.
//Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

int FindTwoDigit (int[] array)
{
    int sumElements = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 9 && array[i] < 100) sumElements++;
    }

    return sumElements;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}

int size = 12;

Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

ShowArray(myArray);

Console.WriteLine($"{FindTwoDigit(myArray)}"); */

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Method (int[] array)
{
    int gather = 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
    Console.Write($"{array [i] *= array[array.Length - gather]} | ");
    gather++;
    }

    if(array.Length % 2 == 0) {}
    else Console.Write($"{array [array.Length / 2]} | ");
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}

int size = 11;

Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

ShowArray(myArray);

Method(myArray);