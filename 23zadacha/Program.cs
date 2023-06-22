
/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

Console.Clear();

int i = 0;
int number;

try
{
    Console.Write("Введите число N: ");
    number = int.Parse(Console.ReadLine());
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

Console.Write($"{number} -> ");

while (i < number - 1)
{
    i = i + 1;
    Console.Write($"{i * i * i},");
}
i = i + 1;
Console.Write($"{i * i * i}");