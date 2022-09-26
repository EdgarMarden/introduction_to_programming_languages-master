Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    
    int [,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Console.WriteLine();

int[,] myArray2 = CreateRandom2dArray(rows, columns, minValue, maxValue);


void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void ShowMatrix (int [,] array, int [,] array2)
{
    int i = 0;
    int j = 0;
    int i2 = 0;
    int j2 = 0;

    while(i < array.GetLength(0))
    {
        while(j < array.GetLength(1))
        {
            Console.Write(array[i, j] + " ");
            j++;
        }
        Console.Write(" | ");

        while(i2 == i)
        {
            j2 = 0;
            while(j2 < array2.GetLength(1))
            {
                Console.Write(array2[i2, j2] + " ");
                j2++;
            }
            
        i2++;
        }

        Console.WriteLine();
        j = 0;
        i++;
    }

    Console.WriteLine();
}

void SortedArray (int [,] array, int rows, int columns)
{
    int count = 1;
    while(count != 0)
    {
        count = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 1; j < columns; j++)
            {
                if(array [i, j] > array [i, j - 1]) 
                {
                    int temp = array [i, j];
                    array [i, j] = array [i, j - 1];
                    array [i, j - 1] = temp;
                    count++;
                }
            }
            
        }
    }
}

int FindMinSumRow (int [,] array)
{
    int minSum = 0;
    int sum = 0;
    int findRowMinSum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum = 0;

        for (int j = 0; j < columns; j++)
            sum += array[i, j];

        if (i == 0)
        {
            minSum = sum;
            findRowMinSum = 0;
        }

        if (minSum > sum) 
        {
            minSum = sum;
            findRowMinSum = i;
        }
    }
    return findRowMinSum;
}

void MultiplyMatrices (int [,] array, int [,] array2)
{
    int [,] multiplyArray = new int [array.GetLength(0), array2.GetLength(1)];
    int temp = 0;
     for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (i = 0; i < array2.GetLength(0); i++)
            {
                for (j = 0; j < array2.GetLength(1); j++)
                {
                    for (i = 0; i < multiplyArray.GetLength(0); i++)
                    {
                        for (j = 0; j < multiplyArray.GetLength(1); j++)
                        {
                            if(i % 2 == 0) 
                            {
                                multiplyArray [i, j] = array[i, j] * array2 [i, j];
                                temp = multiplyArray [i, j];
                            }
                            else 
                            {
                                multiplyArray [i, j] = array[i, j] * array2 [i, j] + temp;
                                Console.Write(multiplyArray[i, j] + " ");
                            }

                            Console.WriteLine();
                        }
                    }
                }
            }
        }
     }
}

/* Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

//Решение Задачи №54

/* Show2dArray(myArray);

SortedArray(myArray, rows, columns);

Show2dArray(myArray); */



/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и
выдаёт номер строки с наименьшей суммой элементов: 1 строка */

//Решение Задачи №56

/* Show2dArray(myArray);

Console.WriteLine("Row " + FindMinSumRow(myArray) + " with the smallest sum of elements"); */


/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18 */

//Решение Задачи №58

/* Show2dArray(myArray);

Show2dArray(myArray2); */

ShowMatrix(myArray, myArray2);

/* MultiplyMatrices(myArray, myArray2); */


/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

//Решение Задачи №60



/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

//Решение Задачи №62

