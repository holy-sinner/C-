// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
// 1. Input
int A = GetNumberFromUser("Введите число  : ", "Ошибка ввода!");


// 2. Calculations
int result = GetResult(A);

// 3. Output
Console.WriteLine($"{A} -> {result}");

////////////////////////////
int GetResult(int number)
{
    int res = 0;


    while (number > 0)
    {
        res = res + (number % 10);
        number = number / 10;
    }
    return res;
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