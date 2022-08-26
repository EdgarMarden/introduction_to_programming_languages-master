/*
Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

/*
int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;

    int max;
    if(ed > dec) max = ed;
    else max = dec;
    
    return max; //строго тот же тип переменной
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");
*/



//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int FindSecond(int number)
{
    int lastNumber = number % 10;
    int firstNumber = number / 100;

    int newNumber = firstNumber * 10 + lastNumber;
    
    return newNumber;
}

int randomNumber = new Random().Next(101, 1001);
int completeNumber = FindSecond(randomNumber);

Console.WriteLine($"Cut version of {randomNumber} is {completeNumber}");



//Напишите программу, которая будет принимать на вход два числа
//и выводить, является ли второе число кратным первому.
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

void Multiplicity (int a, int b)
{
    int ostatok = b % a;
    if (ostatok == 0)
        Console.WriteLine($"Yes, number {b} is multiplicity of number {a}");
    else Console.WriteLine($"No, number {b} is multiplicity of number {a} the remainder of the division {ostatok} ");
}

Console.Write("Input first number: ");
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Input second number: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

Multiplicity(number1, number2);