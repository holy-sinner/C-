// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int m = GetNumberFromUser("Введите число элементов массива :", "Ошибка ввода :(");

int [] array = GetArray(m);

int finded = GetCount(array);

Console.WriteLine($"{String.Join(",", array)} -> {finded}");

int[] GetArray(int size) 
 {

    int[] res = new int[size];
    for(int i=0;i<size; i++)  
    {
       res[i] = GetNumberFromUser("Введите элемент массива :", "Ошибка ввода :(");

    }
    return res;
 }
int GetCount(int [] arr)
{
     int sum = 0;
     foreach (int el in arr)  
     {                        
         if (el > 0) sum ++;

     }
     return sum;
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

