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
//a < b + c
//b < c + a
//c < b + a

/* bool CheckSide(int aSide, int bSide, int cSide)
{
    if(aSide < bSide + cSide);
    else return false;
        if(bSide < aSide + cSide);
        else return false;
            if(cSide < bSide + aSide);
            else return false;
    return true;
}

Console.Write("Enter the length of side A of the triangle: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the length of side A of the triangle: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the length of side A of the triangle: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Can there be a triangle with sides of this length? - {CheckSide(a, b, c)}"); */

//Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: a и b. F(n) = F(n-1) + F(n-2)

/* int[] CreateRandomArray(int sizeN, int firstValue, int secondValue)
{
    int[] newArray = new int[sizeN];
    newArray[0] = firstValue;
    newArray[1] = secondValue;
    for(int i = 2; i < sizeN; i++)
    { 
        newArray[i] = newArray[i - 1] + newArray[i - 2];
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}

Console.Write("Enter how many Fibonacci numbers to output ");
int sizeN = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the first value: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second value: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(sizeN, firstValue, secondValue);

Console.WriteLine();
ShowArray(myArray); */

//Напишите программу,которая будет преобразовывать
//десятичное число в двоичное.

string FromDecimalToBinary(int decim)
{
    string element = string.Empty;
    while(decim > 0)
    {
        int result = decim % 2;
        element = Convert.ToString(result) + element;
        decim /= 2;
    }
    return element;
}

Console.Write("Enter the any decim value: ");
int decimValue = Convert.ToInt32(Console.ReadLine());

Console.Write($"{FromDecimalToBinary(decimValue)}");