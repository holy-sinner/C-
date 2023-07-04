// Задача 31 




Console.Clear();

// int [] array = GetArray(12, -9, 9); // Вызываем функцию (кол-во эл-тов,минимальное,макисмальное)
// Console.WriteLine(String.Join(",", array)); // String.Join метод выводв массива (параметр который выводится между эл-тами массива, имя массива )

// int positiveSum = GetPositiveSum(array);
// int negativeSum = GetNegativeSum(array);

// Console.WriteLine($"Positive Sum = {positiveSum}, negative Sum = {negativeSum}");

// int[] GetArray(int size,int minValue, int maxValue) // int[] означает одномерный массив 
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1); // второй параметр не включается в диапазон поэтому +1
//     }
//     return res;
// }

// // int GetPositiveSum(int [] arr)
// // {
// //     int sum = 0;
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //     if (arr[i] > 0) sum = sum + arr[i];
// //     }
// //     return sum;
// // }

// // int GetNegativeSum(int [] arr)
// // {
// //     int sum = 0;
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //     if (arr[i] < 0) sum = sum + arr[i];
// //     }
// //     return sum;
// // }

// int GetPositiveSum(int [] arr)
// {
//     int positiveSum = 0;
//     foreach (int el in arr)  // foreach можно использовать только для чтения когда нет необходимости что то менять в цикле
//     {                        // in делит на 2 части в правой массив 
//         if (el > 0) positiveSum += el;

//     }
//     return positiveSum;
// }

// int GetNegativeSum(int [] arr)
// {
//     int negativeSum = 0;
//     foreach (int el in arr)
//     {
//         negativeSum += el < 0 ? el : 0;  // если условие выполнено то возвращает то что между ? и :

//     }
//     return negativeSum;
// }


// int [] array = GetArray(6, -9, 9);
// PrintArray(array);
// ArrayTrans(array);
// Console.Write(" -> ");
// PrintArray(array);



// int[] GetArray(int size,int minValue, int maxValue) // int[] означает одномерный массив 
// {
//      int[] res = new int[size];
//      for (int i = 0; i < size; i++)
//      {
//          res[i] = new Random().Next(minValue, maxValue + 1); // второй параметр не включается в диапазон поэтому +1
//      }
//      return res;
// }

// int[] ArrayTrans(int [] arr)
// {

//     for (int i = 0; i< arr.Length ; i++)
//     {
//         arr[i] = -(arr[i]); 
//     }
//     return arr;

// }

// void PrintArray(int[] arr)
// {
//     int count = arr.Length;
//     int position = 0;



//     Console.Write("[");
//     while (position < count - 1)
//     {

//         Console.Write($"{arr[position]},");
//         position++;
//     }
//     Console.Write($"{arr[position]}]");
// }





int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода :(");
int min = GetNumberFromUser("Введите мин число в массиве: ", "Ошибка ввода :(");
int max = GetNumberFromUser("Введите макс число в массиве: ", "Ошибка ввода :(");
int A = GetNumberFromUser("Введите число которое ищем: ", "Ошибка ввода :(");

int[] array = GetArray(size, min, max);

bool finded = IsExist(A, array); // создаем переменную которой присваиваем да или нет 

Console.Write($"{A}; массив [ {String.Join(",", array)} ] -> {(finded ? "Да": "Нет")}"); // вызов переменной bool при выводе на экран 



bool IsExist(int num, int [] arr)

{
    foreach(int el in arr)
    {
        if (el == num)
            return true ;

    }
    return false; 

}

int GetNumberFromUser(string message, string errormessage)

{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errormessage);
    }
}

int[] GetArray(int size, int minValue, int maxValue) // int[] означает одномерный массив 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // второй параметр не включается в диапазон поэтому +1
    }
    return res;
}

// void IsExist(int find, int[] arr)
// {
//     string res = "нет";

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == find)
//         {
//             res = "да";
//         }
        
        
//     }
//     Console.Write($"{res} ");
// }