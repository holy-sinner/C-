Console.Clear();

void FillArray(int[] array)

{
    int length = array.Length;
    int index = 0;
    Console.WriteLine("Введите элементы массива:");
    
    while (index < length - 1)
    
    {
        
        array[index] = int.Parse(Console.ReadLine());
        Console.Write($"{array[index]}");
        Console.Write($",");
        index++;
    }
    

}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;



    Console.Write("[");
    while (position < count - 1)
    {

        Console.Write($"{arr[position]},");
        position++;
    }
    Console.Write($"{arr[position]}]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
