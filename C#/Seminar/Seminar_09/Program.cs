// Задайте значение N.Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

Console.Write("Input number of M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void ShowNums (int n)
{
    if(n > 1)
    {
        Console.Write(n +" ");
        if(n > 1) ShowNums(n - 1);
    }

    Console.Write(n +" ");
}

// ShowNums(numberN);

// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.

int SumOfDigigts (int n)
{
    if(n > 0) return SumOfDigigts(n / 10) + n % 10;
    else return 0;
}

// Console.Write(SumOfDigigts(numberN)); 

// Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.

void ShowIntervalNums (int m, int n)
{
    if(n > m)
    {
        if(n > m) ShowIntervalNums(m, n - 1);
        Console.Write(n + " ");
    }

    else
    {
        if(m > n) ShowIntervalNums(m, n + 1);
        Console.Write(n + " ");
    }
}

ShowIntervalNums(numberM, numberN);

// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

int PowValue (int m, int n)
{
    if(n > 1) return PowValue(m, n - 1) * m;
    else return m;
}
Console.WriteLine();
Console.WriteLine(PowValue(numberM,numberN));