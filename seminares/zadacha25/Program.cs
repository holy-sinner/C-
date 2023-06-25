//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
// 1. Input
int A = GetNumberFromUser("Введите целое число A : ", "Ошибка ввода!");
int B = GetNumberFromUser("Введите целое число B : ", "Ошибка ввода!");

// 2. Calculations
int result = GetResult(A,B);

// 3. Output
Console.WriteLine($"{A},{B} -> {result}");

////////////////////////////
int GetResult(int number1, int number2)
{
    int res = number1;
    int i = 1;
    while (number2 > 1)
    {
        res = res * number1;
        number2 = number2 - 1;
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