/*

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int kvadrat = number * number;

Console.WriteLine("The quad of number " + number + " is " + kvadrat);

Console.WriteLine($"The quad of {number} is {kvadrat}");

*/




/* 

//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int twoNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber == twoNumber * twoNumber)
{
    Console.WriteLine("Yes, first number is quad of second number");
}
else
{
    Console.WriteLine("No, first number is not quad of second number");
}

*/



/*

//Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input the any number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
int count = -anyNumber;

while(count <= anyNumber)
{
    Console.WriteLine(count);
    count++;
}
Console.WriteLine("Finish");

*/