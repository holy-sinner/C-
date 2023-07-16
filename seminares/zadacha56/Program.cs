// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int numberMinRow = Numberofrow(array);

Console.WriteLine($"Cтрока с наименьшей суммой элементов: {numberMinRow} строка");



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

int Numberofrow ( int [,] arr) // Вычисляем номер строки 

{
    
    int [] temparr = SumColumns (arr); 
    int min = temparr[0] ;
    int result = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (temparr[i] < min)
        {
            result = i;
        }

    }
    return result;


}

int [] SumColumns (int [,] arr) // Создаем временный массив из полученной суммы каждой из строк 
{
    int [] result = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        result[i] = TempArr(arr,i);
    }
    return result;

}


int TempArr ( int [,] arr,int n ) // создаёв временный массив из элементов строки 
{
    int[] temparr = new int[arr.GetLength(1)];
    int result;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temparr[i] = arr[n,i];
    }
    result = SumofRrow(temparr);
    return result;
}

int SumofRrow (int [] arr) // Считаем сумму элементов временного массива 
{
 int sum = 0;
 for (int i = 0; i < arr.Length; i++)
 {
    sum = sum + arr[i];
 }
return sum;

}