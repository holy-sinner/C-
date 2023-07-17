
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = GetArray(4, 4);

PrintArray(array);

int[,] GetArray(int a, int b)
{
    int[,] result = new int[a, b];
    int count = 1;
    int cycle = 0;

    while (count < a * b)
    {

        for (int j = cycle ; j < b - 1 - cycle; j++)
        {

            result[cycle , j] = count;
            count++;

        }

        for (int i = cycle ; i < a - 1 - cycle; i++)
        {
            result[i, b - 1 - cycle ] = count;
            count++;

        }

        for (int j = b - 1 - cycle ; j > cycle ; j--)
        {

            result[a - 1 - cycle, j] = count;
            count++;

        }


        for (int i = a - 1 - cycle; i > cycle; i--)
        {
            result[i, cycle] = count;
            count++;

        }

        cycle++;

 
    }


    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }

}