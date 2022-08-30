//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

 //Решение задачи №19

bool FindPoly(int anyNumber)
{
    int b = anyNumber % 10;
    int a = anyNumber / 10;
    bool c = a == b;

    while(anyNumber > 99)
    {
        anyNumber /= 10;
        a = anyNumber;
        while (a > 9) a /= 10;
        if(a == b)
        {
            c = a == b;
            b = anyNumber % 10;
        }
        else;
    }
    return c;
}

Console.Write("Hi people, enter please any number from 10 to 999 999: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
bool Boolean = FindPoly(userNumber);

Console.WriteLine($"{userNumber} -> {Boolean}");


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//Решение задачи №21
/*
double FindSqrt(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)); // вычисляет квадратный корень √ ( x B − x A ) 2 + ( y B − y A ) 2 + ( z B − z A ) 2
}

Console.Write("Enter the 1st coordinate, axis X: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the 1st coordinate, axis Y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the 1st coordinate, axis Z: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the 2st coordinate, axis X: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the 2st coordinate, axis Y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the 2st coordinate, axis Z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distance = FindSqrt(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"A ({xA}, {yA}, {zA}); B ({xB}, {yB}, {zB}) -> {distance}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*//Решение задачи №23
void Qudrat(int completeNumber)
{
    int n = 1;
    while (n <= completeNumber)
    {
        Console.Write($"{n * n * n} ");
        n++;
    }
}

Console.Write("Input the any number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Qudrat(userNumber);
*/