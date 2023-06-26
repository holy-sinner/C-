Console.Clear();

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    
    while (position < count -1 )
    {
        
        Console.Write($"{col[position]},");
        position++;
    }
    
    Console.Write($"{col[position]}");
    Console.Write(" -> ");
 
    count = col.Length;
    position = 0;

    Console.Write("[");
        while (position < count -1 )
    {
        
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write($"{col[position]}]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
