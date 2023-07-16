// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите min: ");
int min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите max: ");
int max = int.Parse(Console.ReadLine() ?? "");

int[,] matrix1 = GetArray(rows, columns, min, max);
int[,] matrix2 = GetArray(rows, columns, min, max);

int[,] resultMatrix = GetMatrix(matrix1,matrix2);

PrintArray(matrix1); 
Console.WriteLine();
PrintArray(matrix2); 
Console.WriteLine();
PrintArray(resultMatrix); 







int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

int [,] GetMatrix (int[,] arr1,int[,] arr2 )
{
    int[,] result = new int[arr2.GetLength(0),arr2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = GetElement (arr1,arr2,j);
        }
    }
    return result;
}

int GetElement (int[,] arr1,int[,] arr2,int numb )
{
    int result = 0;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        result = result + arr1[numb,i] * arr2[i,numb];
    }
    return result;

}

