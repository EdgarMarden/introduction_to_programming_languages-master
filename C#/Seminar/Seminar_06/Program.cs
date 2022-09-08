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

int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
}

Console.WriteLine();

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.WriteLine();
ShowArray(myArray);
Console.WriteLine();

ReverseArray(myArray);
ShowArray(myArray);
Console.WriteLine(); */

//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.



//Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: a и b.

//Напишите программу,которая будет преобразовывать
//десятичное число в двоичное.