Console.Write("Input number of M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

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

int SumValue (int m, int n)
{
    if(n > 1) return SumValue(m, n - 1) + n;
    else return m;
}

int Ankerman (int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return Ankerman (m - 1, 1);
    if(m > 0 && n > 0) return Ankerman(m - 1, Ankerman(m, n - 1));
    else return 0;
}

/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

/* // Решение Задачи №64

ShowIntervalNums(numberM, numberN); */

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 в Примере ошибка должно быть 39 Итог*/

/* // Решение Задачи №66

Console.WriteLine(SumValue(numberM, numberN)); */

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

// Решение Задачи №68

Console.WriteLine(Ankerman(numberM, numberN));
