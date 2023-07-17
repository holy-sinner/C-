Console.Clear();

Console.Write("Введите число N : ");
string userInput = Console.ReadLine() ?? "";
int n = int.Parse(userInput);
int i = 0;


while (i < n)
{
    i = i + 2;
    Console.Write($"{i},");
}