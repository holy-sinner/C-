/*
Console.Clear();

int X, Y;

try
{
    Console.Write("Введите X: ");
    X = int.Parse(Console.ReadLine());

    Console.Write("Введите Y: ");
    Y = int.Parse(Console.ReadLine());
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}


if (X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}


Console.Clear();

Console.WriteLine("Введите номер четверт:");

string userinput = Console.ReadLine();
int x = int.Parse(userinput);

if (x == 1)
{
    Console.WriteLine($" {x} ->  x > 0 , y > 0");
}
else if (x == 2)
{
    Console.WriteLine($" {x} ->  x < 0 , y > 0");
}
else if (x == 3)
{
    Console.WriteLine($" {x} ->  x < 0 , y < 0");
}
else if (x == 4)
{
    Console.WriteLine($" {x} ->  x > 0 , y < 0");
}
else 
{
    Console.WriteLine($" Такой четверти не существует! ");
}
*/

Console.Clear();

int x1, y1, x2, y2;


try
{
    Console.Write("Введите x1: ");
    x1 = int.Parse(Console.ReadLine());

    Console.Write("Введите y1: ");
    y1 = int.Parse(Console.ReadLine());
        
    Console.Write("Введите x2: ");
    x2 = int.Parse(Console.ReadLine());

    Console.Write("Введите y2: ");
    y2 = int.Parse(Console.ReadLine());
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

double distance = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
Console.WriteLine($"Расстояние = {distance:f3}"); 


/*
Console.Clear();

int i = 0;
int number;

try
{
    Console.Write("Введите число N: ");
    number = int.Parse(Console.ReadLine());
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

while (i < number)
{
      i = i+1;
      Console.WriteLine($"{i*i}");
}*/