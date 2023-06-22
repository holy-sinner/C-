/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/



Console.Clear();
Console.WriteLine("Введите пятизначное число:");

string number = Console.ReadLine();
int pol = int.Parse(number);

if (pol > 99999)
{
    Console.WriteLine($"Число {pol} не пятизначное!!11");
}
else if (((pol / 10000 == pol % 10)) && ((pol / 1000) % 10 == (pol % 100) / 10))
{
    Console.WriteLine($"{pol} -> да");
}
else
{
    Console.WriteLine($"{pol} -> нет");
}
