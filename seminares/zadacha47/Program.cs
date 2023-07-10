﻿//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите минимальное значение элемента: ");
int min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите максимальное значение элемента: ");
int max = int.Parse(Console.ReadLine() ?? "");


double[,] array = GetArray(rows, columns, min, max);
PrintArray(array);


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = minValue + (new Random().NextDouble ()) * (maxValue-minValue) ;
        }
    }
    return result;
}



void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}
