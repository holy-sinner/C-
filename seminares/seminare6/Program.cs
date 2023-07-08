// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(",", array));

// int[] reversArray = ReversArray1(array);
// Console.WriteLine(String.Join(",", reversArray));

// ReversArray2(array);
// Console.WriteLine(String.Join(",", array));




// int[] GetArray(int size, int minValue, int maxValue) // int[] означает одномерный массив 
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1); // второй параметр не включается в диапазон поэтому +1
//     }
//     return res;
// }

// int[] ReversArray1(int[] inArray)
// {
//      int[] result = new int[inArray.Length];
//      for(int i = 0; i < inArray.Length; i++)
//      {
//         result[i] = inArray[inArray.Length - 1 - i];
//      }   
//     return result;
// }

// void ReversArray2(int[] inArray)
// {
//     for(int i = 0; i< inArray.Length /2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = k;

//     }


// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// int a = GetNumberFromUser("Введите сторону треуголника 1:", "Ошибка ввода :(");
// int b = GetNumberFromUser("Введите сторону треуголника 2:", "Ошибка ввода :(");
// int c = GetNumberFromUser("Введите сторону треуголника 3:", "Ошибка ввода :(");


// bool finded = IsExist(a, b, c);

// Console.WriteLine($"{finded}");

// bool IsExist(int a, int b, int c)
// {
// if (a + b < c && a + c < b && b + c < a) return true;
//     return false;    
// }

// int GetNumberFromUser(string message, string errormessage)

// {
//     while (true)
//     {
//         Console.Write(message);
//         if (int.TryParse(Console.ReadLine(), out int userNumber))
//             return userNumber;

//         Console.WriteLine(errormessage);
//     }
// }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int number = GetNumberFromUser("Введите число:", "Ошибка ввода :(");

// int [] array = GetArray(number);


// Console.WriteLine($"{number} -> {String.Join("", array)}");


// int [] GetArray(int num)
// {
//      int temp = num;
//      int count = 0;
//      while (temp > 0)
//     {
//          temp = temp/2;
//          count++;
        
//     }   
//      int [] massiv = new int[count];
//      int i = massiv.Length - 1;
//      massiv[0] = 1;
//      while (i > 1)
//     {
//         massiv[i] = num % 2;
//         num = num / 2;  
//         i--;
//     }
//     return massiv;
// }

//  int GetNumberFromUser(string message, string errormessage)

//  {
//      while (true)
//      {
//          Console.Write(message);
//          if (int.TryParse(Console.ReadLine(), out int userNumber))
//              return userNumber;

//          Console.WriteLine(errormessage);
//      }
//  }


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



// int number = GetNumberFromUser("Введите число N:", "Ошибка ввода :(");

// int [] array = GetArray(number);

// Console.WriteLine($" Если N = {number} -> {String.Join(" ", array)}");




//  int[] GetArray(int size) 
//  {
//      int[] res = new int[size];
//      res [0] = 0;
//      res [1] = 1;
     
//      for (int i = 2; i < size; i++)
//      {
//          res[i] = res [i - 1] + res [i - 2];
//      }
//      return res;
//  }


//   int GetNumberFromUser(string message, string errormessage)

//   {
//       while (true)
//       {
//           Console.Write(message);
//           if (int.TryParse(Console.ReadLine(), out int userNumber))
//               return userNumber;

//           Console.WriteLine(errormessage);
//       }
//   }


  //Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.