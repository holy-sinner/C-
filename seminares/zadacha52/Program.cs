// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите min: ");
int min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите max: ");
int max = int.Parse(Console.ReadLine() ?? "");


int[,] array = GetArray(rows, columns, min, max);

PrintArray(array);
double[] mean = MeanArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintMeanArray(mean);


//Finded(array);



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

double[] MeanArray(int[,] arr)

{
    double[] meanArr = new double[arr.GetLength(1)];

    
    
    for (int j = 0;j < arr.GetLength(1); j++)
    {
        double sum = 0;    
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        meanArr[j] = sum / arr.GetLength(0);
        
    }
    return meanArr;
}

void PrintMeanArray(double[] inArray)
{
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Console.Write($"{inArray[i]:f1} ; ");
    }
    Console.Write($"{inArray[inArray.Length-1]:f1}. ");
}

// void Finded(int[,] inArray)
// {
//     int j = 0;
//     double mean = 0;
//     while (j < inArray.GetLength(1) - 1)
//     {

//         for (int i = 0; i < inArray.GetLength(0); i++)
//         {
//             mean = mean + inArray[i, j];
//         }
//         Console.Write($"{mean / inArray.GetLength(0)} ; ");
//         j++;
//     }

//     mean = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         mean = mean + inArray[i, j];
//     }
//     Console.Write($"{mean / inArray.GetLength(0)}.");


// }