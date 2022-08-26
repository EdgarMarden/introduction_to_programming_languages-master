//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

//Решение задачи №19

void FindPoly(int anyNumber)
{
//Нашел последнюю цифру числа
    double b = anyNumber % 10;
    double a = anyNumber;
    double c;
//Привожу число которое ввел пользователь к числу меньше 99
    while(a < 99) a = a / 10;
//Если число введенное пользователем до 99 то делим его на 10 и получаем первое число
    a = a / 10;
//Проверяем равняется ли первое число последнему
    while(a == b)
    {
        if(a < anyNumber);
        a = a * 10;
        b = mkkkkkkkkkkkkkkkkk anyNumber / 10 % 10;
    }

    if(anyNumber < 99)
        if(a == b) Console.WriteLine($"{anyNumber} -> Yes");
        else Console.WriteLine($"{anyNumber} -> No");
    else;
}
Console.Write("Hi people, enter please any number from 10 to 999 999: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
FindPoly(userNumber);

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