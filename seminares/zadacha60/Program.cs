// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] array = GetArray(2,2,2);

PrintArray(array);



int[,,] GetArray(int a, int b,int c)
{
    int[,,] result = new int[a,b,c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                
                result[i, j, k] = Proverka(result,i,j,k);
                
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int k = 0; k < inArray.GetLength(2); k++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        
    }

}

int Proverka (int[,,]arr,int a,int b,int c )
{
    
    int result = new Random().Next(10, 100);
    
    foreach (int el in arr)
    while (result == el)
    {
        result = new Random().Next(10, 100);
        

    }
    return result;


}


// for (int k = 0; k < GetLength(2); k++)
// {
//     for (int i = 0; i < GetLength(0); i++)
//     {
//         for (int j = 0; j < GetLength(1); j++)
//         {
            
//         }
//     }
// }