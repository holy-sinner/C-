// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");

int m = int.Parse(Console.ReadLine()??"");

Console.Write("Введите число N: ");

int n = int.Parse(Console.ReadLine()??"");

Console.Write($"M = {m} ; N = {n} -> {GetSum(m,n)}");

int GetSum(int start, int end)
{
    if(start==end)
        return start;

    return start + GetSum(start + 1,end);

} 