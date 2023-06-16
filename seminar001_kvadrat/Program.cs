Console.Clear();
Console.Write("Введите целон число : ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

int result = userNumber*userNumber;

Console.WriteLine($" {userNumber} -> {result}");


