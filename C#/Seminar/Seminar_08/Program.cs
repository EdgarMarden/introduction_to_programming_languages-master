//Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

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

void ChangeRowsAtColumns(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i != j)
            {
                int temp = array [i, j];
                array[i, j] = array [j, i];
                array[j, i] = temp;
            }
        }
    }
}

/* int[,] myArray = CreateRandom2dArray();
Console.WriteLine();

Show2dArray(myArray);
ChangeRows(myArray, 0, 8);
Show2dArray(myArray); */

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] myArray = CreateRandom2dArray();
Console.WriteLine();

Show2dArray(myArray);

ChangeRowsAtColumns(myArray);

Show2dArray(myArray);


// Из двумерного массива целых чисел удалить строку
// и столбец, на пересечении которых расположен наименьший элемент.



// Написать программу поэлементного копирования массива.

