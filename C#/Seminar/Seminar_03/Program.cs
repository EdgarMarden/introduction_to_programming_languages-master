/*
Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер четверти плоскости,
в которой находится эта точка.
*/

/*
int FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input coordinate X: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinate Y: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xA, yA);

Console.WriteLine($"Num of quad is {quadrant}");
*/

/*
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

/*
void FindRange(int quadrant)
{
 if(quadrant == 1) Console.Write("Range is: x > 0, y > 0");
 if(quadrant == 2) Console.Write("Range is: x < 0, y > 0");
 if(quadrant == 3) Console.Write("Range is: x > 0, y < 0");
 if(quadrant == 4) Console.Write("Range is: x > 0, y < 0");
 if(quadrant < 1 || quadrant > 4) Console.Write("Not is quadrant");
}

Console.Write("Input the quadrant: ");
int range = Convert.ToInt32(Console.ReadLine());
FindRange(range);
*/

/*
Напишите программу, которая принимает на вход число (n)
и выдаёт квадраты чисел от 1 до n
*/

/*
void Qudrat(int completeNumber)
{
    int n = 1;
    while (n <= completeNumber)
    {
        Console.Write($"{n * n} ");
        n++;
    }
}

Console.Write("Input the any number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Qudrat(userNumber);
*/

/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве. Math.Sqrt()
*/

double FindSqrt(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
}

Console.Write("Enter the 1st coordinate, axis X: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the 1st coordinate, axis Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the 2st coordinate, axis X: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the 2st coordinate, axis Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = FindSqrt(x1, y1, x2, y2);
Console.WriteLine($"{distance} is distance");