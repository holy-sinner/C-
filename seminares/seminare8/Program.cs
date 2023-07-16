//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*
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

int[,] reversArray = GetReversArray(array);

Console.WriteLine();

PrintArray(reversArray);


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

int[,] GetReversArray (int[,] inArray)
{
    int [,] res = inArray;//new int[inArray.GetLength(0),inArray.GetLength(1)];
    
    for (int j = 0 ; j < inArray.GetLength(1) ; j ++  )
    {
        int a = inArray [0,j];
        res [0,j] = inArray [inArray.GetLength(0)-1,j];
        inArray [inArray.GetLength(0) -1,j] = a;


    }


    return res;
} 

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.



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

int[,] transformarray = TransformArray(array);
Console.WriteLine();

PrintArray(transformarray); 


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) ; j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    
}

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

int[,] TransformArray(int[,] arr)
{
    int[,] result = new int [arr.GetLength(1),arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++ )
    {
        for ( int j = 0; j < arr.GetLength(1)  ; j ++  )
        {
            result [j,i] = arr [ i,j];

        }


    }

    return result;
} */



// Задача 57: Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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
Console.WriteLine();

int[,] finalArray = FrequencyArray(array);
PrintArray(finalArray);


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

bool IsContains (int [] arr, int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] == n)
       {
        return true;

       }
    }
    return false;
}


int [] GetUniqArray(int[,] array)

{
    int count = 0;
    int[] uniqTempArray = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!IsContains( uniqTempArray, array[i,j]))
            {
                uniqTempArray [count] = array[i,j];
                count++;

            }
        }
    }
    int [] uniqArray = new int [count];
    for (int i = 0; i < uniqArray.Length; i++)
    {
        uniqArray[i] = uniqTempArray[i];
    }
    Array.Sort(uniqArray);
    return uniqArray;
}


int[,] FrequencyArray(int[,] array)
{
    int[] uniqArray = GetUniqArray(array);
    
    //Console.WriteLine(String.Join(",", uniqArray));
    int[,] frequency = new int [uniqArray.Length,2];
    for (int i = 0; i < uniqArray.Length; i++)
    {
        frequency[i,0] = uniqArray[i];
        frequency[i,1] = GetCount(array,frequency[i,0]);
        
    }
    

    
    return frequency;


}

int GetCount (int [,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        if (array [i,j] == number)  count ++;
        
    }
    return count;
}