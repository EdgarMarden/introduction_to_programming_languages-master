//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


//Задача №41 Решение:

/* string Show(int numbers)
{
    string element = string.Empty;
    int count = 0;

    for(int i = 0; i < numbers; i++)
    {
        Console.Write($"Input any value for {i + 1} numbers: ");
        int value = Convert.ToInt32(Console.ReadLine());
        element = element + Convert.ToString(value) + ", ";

        if(value > 0) count++;
    }  

    element = element + "--> " + count;
    return element;
}

Console.Write("How many numbers do you want to enter? - ");
int count = Convert.ToInt32(Console.ReadLine());

Console.Write($"{Show(count)}"); */


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Задача №43 Решение:

void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x,y;

    if ((k1 == k2) && (b1 == b2)) Console.Write("Straight lines match");
    else if (k1==k2) Console.Write("Straight lines are parallel");

    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x} ; {y})");
    }
}

Console.Write("Enter the value of point A of the first straight line: ");
double firstStraightLineA = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the value of point B of the first straight line: ");
double firstStraightLineB = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the value of point A of the second straight line: ");
double secondStraightLineA = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the value of point B of the second straight line: ");
double secondStraightLineB = Convert.ToDouble(Console.ReadLine());

FindIntersectionPoint(firstStraightLineA, firstStraightLineB, secondStraightLineA, secondStraightLineB);
