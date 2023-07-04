// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода :(");
int minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода :(");
int maxValue = GetNumberFromUser("Введите максимальное значение массива: ", "Ошибка ввода :(");

int [] array = GetArray(size,minValue,maxValue);

int A = SumArray(array);

Console.Write($"[{String.Join(",", array)}] -> {A}");





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

int SumArray(int [] arr)
{
     int sum = 0;
     for (int i = 1; i < arr.Length -1; i = i + 2)  // foreach можно использовать только для чтения когда нет необходимости что то менять в цикле
     {                        // in делит на 2 части в правой массив 
         sum = sum + arr[i];

     }
     return sum;
}