﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Clear();

Console.WriteLine("Введите трёхзначное число:");
string number = Console.ReadLine();
int a = int.Parse(number);

if ((a > 99)&&(a < 1000))
{
int b = a / 10;
int c = b % 10;
Console.WriteLine($"{a}->{c}"); 
}
else
{
Console.WriteLine($"{a}->число не трёхзначное"); 
} */

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int a = int.Parse(number);
if (a > 99)
{
while (a > 1000)
    {
        a = a / 10;
    }
Console.WriteLine($"{number}->{a % 10}");
}
else
{
    Console.WriteLine($"{a}->третьей цифры нет");
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Введите цифру дня недели:");
string number = Console.ReadLine();
int a = int.Parse(number);
if ((a > 0) && (a < 8))
{
    if (a == 6 || a == 7)
    { Console.WriteLine($"{a}-> да"); }
    else
    { Console.WriteLine($"{a}-> нет "); }
}
else
{ Console.WriteLine($"{a}-> такого дня недели нету "); }
*/