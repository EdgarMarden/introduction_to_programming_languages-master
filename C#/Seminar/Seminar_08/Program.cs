//Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Console.WriteLine();

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    
    int [,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
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

void Show2dArrayTranspose(int [,] array, int rows, int columns)
{
    if(rows == columns)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[j, i] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
    }

    else Console.WriteLine("This array cannot be transposed");
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp;
    }
}

void RemoveMinElement (int [,] array, int rows, int columns)
{
    int min = array [0, 0];
    int findRow = 0;
    int findColumn = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                findRow = i;
                findColumn = j;
            }
        }
    }

    Console.WriteLine(findRow + " " + findColumn);
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i != findRow)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if(j != findColumn)
                    Console.Write(array[i, j] + " ");

        Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int [,] Copy2dArray(int [,] array, int rows, int columns)
{
    int [,] copiedArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            copiedArray [i, j] = array [i, j];
        }
    }

    return copiedArray;
}

/* int[,] myArray = CreateRandom2dArray();
Console.WriteLine();

Show2dArray(myArray);
ChangeRows(myArray, 0, 8);
Show2dArray(myArray); */


// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/* Show2dArray(myArray);
Show2dArrayTranspose(myArray, rows, columns); */


// Из двумерного массива целых чисел удалить строку
// и столбец, на пересечении которых расположен наименьший элемент.


/* Show2dArray(myArray);
RemoveMinElement(myArray, rows, columns); */

// Написать программу поэлементного копирования массива.

Show2dArray(myArray);
int[,] copiedArray = Copy2dArray(myArray, rows, columns);
Show2dArray(copiedArray);