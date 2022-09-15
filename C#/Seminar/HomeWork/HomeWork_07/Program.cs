﻿// // Задача 47. Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.

// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// Задача №47 Решение:

// double[,] CreateRandom2dArray()
// {
//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     double [,] newArray = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             newArray[i, j] = Math.Round(new Random().Next(-9, 9) + new Random().NextDouble(), 2);
            
//     return newArray;
// }

// void Show2dArray(double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " | ");

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// double[,] myArray = CreateRandom2dArray();
// Console.WriteLine();

// Show2dArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Задача №50 Решение:

int[,] CreateRandom2dArrayCR(int row, int col)
{
    int minValue = 0;
    int maxValue = 9;

    int [,] newArray = new int[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void FindPosition(int [,] array, int rows, int columns)
{
    Console.Write("Enter the row number: ");
    int findRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the column number: ");
    int findColumn = Convert.ToInt32(Console.ReadLine());

    if(findRow <= rows && findColumn <= columns)
    {
        Console.WriteLine($"The value of the cell in row {findRow} and column {findColumn} = {array[findRow, findColumn]}");
    }
    else
    {
        Console.Write($"The value of the cell in row {findRow} and column {findColumn} = This position does not exist in the current array");
    }
}
    
int rows = 5;
int columns = 5;

int [,] myArray = CreateRandom2dArrayCR(rows, columns);

Show2dArray(myArray);

FindPosition(myArray, rows, columns);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Задача №52 Решение:

/* int[,] CreateRandom2dArray(int row, int col)
{
    
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int [,] newArray = new int[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void FindArithmetic(int [,] array, int row, int col)
{
    double sum = 0;
    Console.Write("The arithmetic mean of each column - ");
    for (int j = 0; j < row; j++)
    {
        for (int i = 0; i < col; i++) sum += array [i, j];
        Console.Write(sum / row + " | ");
    }
        
}

Console.Write("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns);

Show2dArray(myArray);

FindArithmetic(myArray, rows, columns); */