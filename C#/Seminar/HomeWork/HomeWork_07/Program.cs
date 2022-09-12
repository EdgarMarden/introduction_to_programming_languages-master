// // Задача 47. Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.

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

int[,] CreateRandom2dArray(int row, int col)
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

void FindPosition(int [,] array, int size)
{
    Console.Write("Enter the row number: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the column number: ");
    int column = Convert.ToInt32(Console.ReadLine());
    
    int result = array[row - 1, column - 1];
    if(result < size) Console.WriteLine($"The value of the cell in row {row} and column {column} = {result}");
    else
    {
        Console.Write($"The value of the cell in row {row} and column {column} = This position does not exist in the current array");
    }
}
    
int rows = 5;
int columns = 5;
int size = rows * columns;

int [,] myArray = CreateRandom2dArray(rows, columns);

Show2dArray(myArray);

FindPosition(myArray, size);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Задача №52 Решение:


