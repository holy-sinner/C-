
//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine() ?? "");

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine() ?? "");

// int[,] array = GetArray(rows, columns, 0, 10);

// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine() ?? "");

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine() ?? "");

// int[,] array = GetArray(rows, columns);

// PrintArray(array);

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

/*
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите минимальное значение элемента: ");
int min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите максимальное значение элемента: ");
int max = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, min, max);



PrintArray(array);
TransformArray(array);
Console.WriteLine();
PrintArray(array);



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); ;
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void TransformArray(int[,] inArray)
{


    for (int i = 1; i < inArray.GetLength(0); i = i + 2)
    {
        for (int j = 1; j < inArray.GetLength(1); j = j + 2)
        {
            inArray[i, j] = inArray[i, j] * inArray[i, j];
        }

    }

} */

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите минимальное значение элемента: ");
int min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите максимальное значение элемента: ");
int max = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, min, max);

int sum = GetSum(array);

PrintArray(array);

Console.WriteLine($"Сумма элементов главной диагонали: {sum}");



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); ;
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetSum(int [,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int j = i;
        sum = sum + arr[i,j];
        
    }

    return sum;
}