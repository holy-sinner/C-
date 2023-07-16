Console.Clear();

Console.Write("Введите первое число : ");
string userInputA = Console.ReadLine() ?? "";
int userNumberA = int.Parse(userInputA);

Console.Write("Введите второе число : ");
string userInputB = Console.ReadLine() ?? "";
int userNumberB = int.Parse(userInputB);

if (userNumberA == userNumberB * userNumberB)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет((");
}

