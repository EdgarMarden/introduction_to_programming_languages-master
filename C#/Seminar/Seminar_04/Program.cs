//Напишите программу, которая принимает на 
//вход число (А) и выдаёт сумму чисел от 1 до А.

/* int FindSum(int num)
{
    int sum = 0;
    
    for (int current = 1; current <= num; current++)
        sum += current;

    return sum;
}

Console.Write("Input positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}"); */



//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/* int FindDigits(int num)
{
    int digits = 1;

    while(num > 9)
    {
        num /= 10;
        digits ++;
    }
    
    return digits;
}

Console.Write("Input the any number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"the number of digits in the number {anyNumber} = {FindDigits(anyNumber)}"); */


//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/* int FindFactorial(int num)
{
    int factorial = 1;
    
    for (int current = 1; current <= num; current++)
        factorial *= current;

    return factorial;
}

Console.Write("Input positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Factorial of numbers {n} is {FindFactorial(n)}"); */

//Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

int [] CreateArray(int arraySize, int min, int max)
{
    int [] array = new int [arraySize];

    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(min, max + 1);
        Console.Write($"{array[i]} ");
    }
    
    return array;
}

Console.Write("Input array size: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value for array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value for array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(sizeArray, minValue, maxValue);

