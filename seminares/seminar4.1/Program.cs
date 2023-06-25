/*Console.Clear();
// 1. Input
int A = GetNumberFromUser("Введите целое число N : ", "Ошибка ввода!");

// 2. Calculations
int composition = GetComposition(A);

// 3. Output
Console.WriteLine($"{A} -> {composition}");

////////////////////////////
int GetComposition(int number)
{
    int comp = 1;
    while (number > 0)
    {
        comp = comp * number;
        number = number - 1;
    }
    return comp;
}
int GetNumberFromUser(string message, string errormessage)

{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errormessage);
    }
}




Console.Clear();

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count -1 )
    {
        
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write($"{col[position]}]");
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {

        if (collection[index] == find)
        {
            position = index;
            break;

        }
        index++;

    }
    return position;
}


int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();*/

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int i = 0;
Console.Write("[");
while (i<7)
{
    Console.Write(new Random().Next (0,2));
    Console.Write(",");
    i++;
}
Console.Write(new Random().Next (0,2));
Console.Write("]");
