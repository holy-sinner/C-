

Console.Write("Введите число N : ");
string userInput = Console.ReadLine() ?? "";
int n = int.Parse(userInput);
int i = 0;
Console.Write($"{n}->");

while (i < n - 3)
{
    i = i + 2;
    Console.Write($"{i},");

}
i = i + 2;
Console.Write($"{i}");