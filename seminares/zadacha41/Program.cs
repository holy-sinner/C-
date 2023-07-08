// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int a = GetNumberFromUser("Введите число 1:", "Ошибка ввода :(");
int b = GetNumberFromUser("Введите число 2:", "Ошибка ввода :(");
int c = GetNumberFromUser("Введите число 3:", "Ошибка ввода :(");
int d = GetNumberFromUser("Введите число 4:", "Ошибка ввода :(");
int e = GetNumberFromUser("Введите число 5:", "Ошибка ввода :(");



int [] array = GetArray(a, b, c, d, e);

int finded = GetCount(array);

Console.WriteLine($"{a},{b},{c},{d},{e}=> {finded}");



 int[] GetArray(int a,int b,int c,int d,int e) 
 {

     int[] res = new int[5];
     res[0] = a;
     res[1] = b;
     res[2] = c;
     res[3] = d;
     res[4] = e;
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

