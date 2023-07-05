// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода :(");
int minValue = GetNumberFromUser("Введите минимально число в массиве: ", "Ошибка ввода :(");
int maxValue = GetNumberFromUser("Введите максимальное число в массиве: ", "Ошибка ввода :(");


double [] array = GetArray(size,minValue,maxValue);
double min = GetMinArray(array);
double max = GetMaxArray(array);

double A = max - min;

Console.Write($"[{String.Join(", ", array)}] -> {A:f2}");


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

double[] GetArray(int size, double minvalue,double maxvalue) 
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = minValue + (new Random().NextDouble ()) * (maxvalue-minvalue);
    }
    return res;
}

double GetMinArray(double[] arr)
{
    double min = arr[0];
    for(int i = 1;i < arr.Length; i++)
    {
        if (arr[i]< min) min = arr[i];
    }
    return min;
}

double GetMaxArray(double[] arr)
{
    double max = arr[0];
    for(int i = 1;i < arr.Length; i++)
    {
        if (arr[i]> max) max = arr[i];
    }
    return max;
}