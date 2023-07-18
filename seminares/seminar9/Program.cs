// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

/*
Console.Write("Введите число M: ");

int m = int.Parse(Console.ReadLine()??"");

Console.Write("Введите число N: ");

int n = int.Parse(Console.ReadLine()??"");

Console.Write($"M = {m} ; N = {n} -> {GetNum(m,n)}");

string GetNum(int start, int end)
{
    if(start==end)
        return start.ToString();

    return start + "," + GetNum(start + 1,n);

} 

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Введите число : ");

int m = int.Parse(Console.ReadLine()??"");



Console.Write($"{m} -> {GetNum(m)}");

int GetNum(int num)
{
    
    if(num == 0)
        return 0;
    
    return num % 10 + GetNum( num / 10);
        

    

}
 */

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.Write("Введите число A: ");

int a = int.Parse(Console.ReadLine()??"");

Console.Write("Введите число B: ");

int b = int.Parse(Console.ReadLine()??"");



Console.Write($"A = {a} B = {b}-> {GetNum(a,b)} ({a} в степени {b}) ");

int GetNum(int a, int b)
{
    
    if(b == 0)
        return 1;
    
    return a * GetNum(a, b - 1);
        

    

}