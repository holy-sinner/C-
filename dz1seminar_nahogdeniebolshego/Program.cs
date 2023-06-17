Console.Clear();

Console.Write("Введите первое число : ");
string userInputA = Console.ReadLine() ?? "";
int a = int.Parse(userInputA);

Console.Write("Введите второе число : ");
string userInputB = Console.ReadLine() ?? "";
int b = int.Parse(userInputB);

if (a >= b)
{
    Console.WriteLine($" a = {a}; b = {b} -> max = {a}");
}
if (b > a)
{
    Console.WriteLine($" a = {a}; b = {b} -> max = {b}");
}
