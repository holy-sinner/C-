// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = GetNumberFromUser("Введите число b1 :", "Ошибка ввода :(");
double k1 = GetNumberFromUser("Введите число k1 :", "Ошибка ввода :(");
double b2 = GetNumberFromUser("Введите число b2 :", "Ошибка ввода :(");
double k2 = GetNumberFromUser("Введите число k2 :", "Ошибка ввода :(");

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * (b2 - b1) / (k1 - k2)) + b1;

Console.WriteLine($"y = k1 * x + b1, y = k2 * x + b2;");
Console.WriteLine($"b1 = {b1}  k1 = {k1}  b2 = {b2}  k2 = {k2} -> ({x:f2};{y:f2})");

double GetNumberFromUser(string message, string errormessage)

{
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out double userNumber))
            return userNumber;

        Console.WriteLine(errormessage);
    }
}




