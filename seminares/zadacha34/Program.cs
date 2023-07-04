// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода :(");
int [] array = GetArray(size);
int A = GetCount(array);


Console.Write($"[{String.Join(",", array)}] -> {A} ");




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

int[] GetArray(int size) // int[] означает одномерный массив 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000); // второй параметр не включается в диапазон поэтому +1
    }
    return res;
}

int GetCount(int [] arr)
{
     int count = 0;
     foreach (int el in arr)  // foreach можно использовать только для чтения когда нет необходимости что то менять в цикле
     {                        // in делит на 2 части в правой массив 
         if (el % 2 == 0) count ++;

     }
     return count;
}