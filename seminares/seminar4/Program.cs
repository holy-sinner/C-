Console.Clear();
// 1. Input
int A = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");

// 2. Calculations
int sumNumbers = GetSumNumbers(A);

// 3. Output
Console.WriteLine($"{A} -> {sumNumbers}");

////////////////////////////
int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number;
        number = number - 1;
    }
    return sum;
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