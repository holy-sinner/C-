// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер в строке: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер в столбце: ");
int n = int.Parse(Console.ReadLine() ?? "");


int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

bool finded = IsExist(array); 
Console.Write($"{m}{n} ->"); 
Finded(finded,array,m,n);


bool IsExist(int[,] inArray)

{
    if (m < inArray.GetLength(0) && n < inArray.GetLength(1))
    {
        return true;      
    }
        return false;    
}

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
void Finded(bool myBoolVar,int [,] arr,int i,int j)
{
    if (myBoolVar == true)
    {
        Console.Write($" {arr[i,j]}");
    }
    else
    {
        Console.Write(" такого элемента нет");
    }
}


// void Finded(int m, int n, int[,] inArray)
// {


//     if (m < inArray.GetLength(0) && n < inArray.GetLength(1))
//     {
//         int i = 0;
//         int j = 0;
//         while (i < m) i++;
//         while (j < n) j++;

//     Console.WriteLine($"Искомый элемент массива : {inArray[i,j]}");     
//     }

//     else { Console.WriteLine($"{m}{n} -> такого числа нет в массиве"); }
// }
