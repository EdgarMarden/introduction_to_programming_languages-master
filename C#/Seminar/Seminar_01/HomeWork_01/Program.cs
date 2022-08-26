/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {a}");
}
else 
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {b}");
}
*/



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7 
//44 5 78 -> 78
//22 3 9 -> 22

/*

Console.Write("enter the value a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("enter the value b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("enter the value c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > b)
{
    max = a;
    if (a > c)
    {
        max = a;
        Console.WriteLine($"a = {a}, b = {b}, c = {c} -> max = {a}");
    }
    else
    {
        max = c;
        Console.WriteLine($"a = {a}, b = {b}, c = {c} -> max = {c}");
    }
}
else 
{
    max = b;
    if (b > c)
    {
        max = b;
        Console.WriteLine($"a = {a}, b = {b}, c = {c} -> max = {b}");
    }
    else 
    {
        max = c;
        Console.WriteLine($"a = {a}, b = {b}, c = {c} -> max = {c}");
    } 
}

*/



//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

/*
Console.Write("enter the value a: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0)
{
    Console.WriteLine($"{a} -> да");
}
else
{
    Console.WriteLine($"{a} -> нет");
}

*/



//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*
Console.Write("enter the value a: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;


while(count <= a)
{
    Console.WriteLine(count);
    count++;
}
*/