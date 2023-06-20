Console.Clear();

Console.WriteLine("Vvedite chislo:");
string chislo = Console.ReadLine();
int a = int.Parse(chislo);
int b = a / 10;
int c = b % 10;


Console.WriteLine($"{a}->{c}");
