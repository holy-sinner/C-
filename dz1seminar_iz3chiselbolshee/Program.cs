Console.Clear();

Console.Write("Введите первое число : ");
string userInputA = Console.ReadLine() ?? "";
int a = int.Parse(userInputA);

Console.Write("Введите второе число : ");
string userInputB = Console.ReadLine() ?? "";
int b = int.Parse(userInputB);

Console.Write("Введите третье число : ");
string userInputC = Console.ReadLine() ?? "";
int c = int.Parse(userInputC);

int max = a;

if (b > a) max = b;
if (c > a) max = c;

Console.WriteLine($" {a},{b},{c} -> max = {max}");



    

