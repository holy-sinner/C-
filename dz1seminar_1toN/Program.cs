Console.Clear();

Console.Write("Введите число N : ");
string userInput = Console.ReadLine() ?? "";
int n = int.Parse(userInput);
int i = 0;
Console.Write($"{n}->");

while (i < n-2 )
{
    i = i + 1;
    if (i%2 == 0)
    Console.Write($"{i},");
}
while (i < n )
{
    i = i + 1;
    if (i%2 == 0)
    Console.Write($"{i}");
}