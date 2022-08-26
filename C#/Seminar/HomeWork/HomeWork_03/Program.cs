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
        else break;
    }
    return c;
}

Console.Write("Hi people, enter please any number from 10 to 999 999: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
bool Boolean = FindPoly(userNumber);

Console.WriteLine($"{userNumber} -> {Boolean}");

/*
    while(a == b)
    {
        if(a == b)
        {
            a *= 10;
            b = anyNumber / 10 % 10;
            Console.WriteLine($"{anyNumber} -> Yes");
        }
        else Console.WriteLine($"{anyNumber} -> No");
    }
}
*/


//Решение задачи №19 - 2 НЕПРАВИЛЬНОЕ
/*
void FindPoly(int anyNumber)
{
    int b = anyNumber % 10;
    int a = anyNumber /;
    while (a > 99)
    {   
        a = a / 10;
        if(a == b)
            while (a == b)
            {
                if (a > 999) a = a / 100;
                else a = a / 100;
                Console.WriteLine($"{anyNumber} -> Yes");
            }
        else Console.WriteLine($"{anyNumber} -> No");
    }
}

Console.Write("Hi people, enter please any number from 10 to 999 999: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
FindPoly(userNumber);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53



//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125