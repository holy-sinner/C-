Console.Clear();

Console.Write("Введите целое число : ");
string userInputA = Console.ReadLine() ?? "";
int a = int.Parse(userInputA);

if (a % 2 == 0)
{
    Console.WriteLine($" {a} -> да");
}
else
{
    Console.WriteLine($" {a} -> нет");
}