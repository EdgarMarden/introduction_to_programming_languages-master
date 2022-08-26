//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*//Решение задачи №10
void SecondNumber (int number)
{
    int secondCharacter = number % 100 / 10;
    Console.WriteLine($"Second character number of {number} is {secondCharacter}");
    Console.WriteLine($"{number} -> {secondCharacter}");
}

Console.Write("Enter a three-digit number: ");
int readNumber = Convert.ToInt32(Console.ReadLine());

SecondNumber(readNumber);
*/



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Решение задачи №13 - данная задача далась тяжело общее время около 4-5-ти часов так как хотелось найти более выгодное решение чем данное.

//Второе решение задачи без проверки нулей, приводя число к трехзначному

int FindThird(int number)
{
    int notThird = -1;
    int thirdNumber;

    if(number < 100) return notThird;
    else 
        while(number > 999) number = number / 10;
        return thirdNumber = number % 10;
}

Console.Write("Input the any Number of 1 - 999 999: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int completeNumber = FindThird(userNumber);

void YesOrNot(int a)
{
    if(a == -1) Console.WriteLine($"{userNumber} -> Not is Third Number");
    else Console.WriteLine($"{userNumber} -> {completeNumber}");
}

YesOrNot(completeNumber);

/*

//Первое решение где нужно проверять кол-во нулей
int FindThird(int number)
{
    int notThird;
    int thirdNumberOf100 = number % 10;
    int thirdNumberOf1000 = number % 100 / 10;
    int thirdNumberOf10000 = number % 1000 / 100;
    int thirdNumberOf100000 = number % 10000 / 1000;
    if(number < 100)
    return notThird = -1;
    else
    {
        if(number < 1000)
        return thirdNumberOf100;
        else
        {
            if(number < 10000)
            return thirdNumberOf1000;
            else
            {
                if(number < 100000)
                return thirdNumberOf10000;
                else {}
            }
        }
    }
    return thirdNumberOf100000;
    
}

Console.Write("Input the any Number of 1 - 999 999: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int completeNumber = FindThird(userNumber);

void YesOrNot(int a, int b)
{
    b = -1;
    if(a == b) Console.WriteLine($"{userNumber} -> Not is Third Number");
    else Console.WriteLine($"{userNumber} -> {completeNumber}");
}

YesOrNot(completeNumber, userNumber);
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

/*
//Решение Задачи №15

void WeekDay(int numberOfWeek)
{
    if (numberOfWeek > 5)
    Console.WriteLine($"{numberOfWeek} -> Yes");
    else
    Console.WriteLine($"{numberOfWeek} -> No");
    
}

Console.Write("Input the Week Day: ");
int findTheWeekDay = Convert.ToInt32(Console.ReadLine());

WeekDay(findTheWeekDay);
*/