// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] newarray = Newarray(array);
Console.WriteLine();

PrintArray(newarray);





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

int[,] Newarray (int [,] arr)
{
    int[,] result = new int[arr.GetLength(0),arr.GetLength(1)];
    int[] temp = new int[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    
    {
        temp = TempArr(arr,i);
        
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
            result[i,j] = temp [j];
        }
       
    }
    


    return result;


}

int [] TempArr ( int [,] arr,int n )
{
    int[] result = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        result[i] = arr[n,i];
    }
    result = BubbleSort(result);
    return result;
}

int [] BubbleSort ( int [] arr)
{
    int [] result = arr;
    int temp;
    
    for (int i = 0; i < arr.Length; i++)
    {
        
        
        for (int j = i+1; j < arr.Length  ; j++)
        {
            if (arr[j]> arr[i])
            {
                temp = arr[i];
                result [i] = arr [j];
                result [j] = temp;

            }
            
        }
        
    }
    
    return result;

}