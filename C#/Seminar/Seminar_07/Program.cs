
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

/* int[,] myArray = CreateRandom2dArray();
Console.WriteLine();

Show2dArray(myArray); */

//Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Aij = i+j.
//Выведите полученный массив на экран.

int[,] Create2ndArrayIJ()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = i + j;

    return newArray;
}

/* int [,] myArrayIJ = Create2ndArrayIJ();
Show2dArray(myArrayIJ); */

//Задайте двумерный массив.
//Найдите элементы, у которых оба индекса чётные,
//и замените эти элементы на их квадраты.

int[,] FindEvenIndexes(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i % 2 == 0)
            for (int j = 0; j < array.GetLength(1); j++)
                if(j % 2 == 0) array[i, j] *= array[i, j];
    }

    return array;
}

/* int[,] myArrayEven = CreateRandom2dArray();
Show2dArray(myArrayEven);
Console.WriteLine();

FindEvenIndexes(myArrayEven);
Show2dArray(myArrayEven);
Console.WriteLine(); */

//Задайте двумерный массив.
//Найдите сумму элементов, находящихся на главной диагонали
//(с индексами (0,0); (1;1) и т.д.

int FindSumDiagonal(int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
            if(j == i) sum += array[i, j];
    }

    return sum;
}

int[,] myArrayDiagonal = CreateRandom2dArray();

Show2dArray(myArrayDiagonal);

Console.Write($"Sum = {FindSumDiagonal(myArrayDiagonal)}");

