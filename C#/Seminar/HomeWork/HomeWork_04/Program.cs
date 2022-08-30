//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Задача №25 Решение
/* int FindDegree (int a, int b)
{
    int current = a;
    for(int i = 2; i <= b; i++) 
    {
        current = current * a;
    }
    return current;
}

Console.Write("Input the value A: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value B: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write($"{first}, {second} -> {FindDegree(first,second)}"); */


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

//Решение задачи №27

/* int FindSum (int a)
{
    int sum = 0;
    int current = a;

    while(a > 9)
    {
        current = a % 10;
        sum = current + sum;
        a /= 10;
    }
    return sum + a; 
}

Console.Write("Input the any positive number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"{anyNumber} -> {FindSum(anyNumber)}"); */


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Решение Задача №29

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    return newArray;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input the value for {i + 1} cell array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Input the array size: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());


ShowArray(CreateArray(sizeArray));
