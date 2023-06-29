// Type1

void Method1()
{
    Console.WriteLine("Author...");
}
//Method1();  //Обязательно указывать скобочки иначе ошибка 
// Type2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Text message");

void Method21(string msg, int count)
{

    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Text",count: 4);
//Method21(count: 4, msg: "New text");

// Type 3

int Method3()
{
    return DateTime.Now.Year; // В таких методах обязателен return
}

int year = Method3();
//Console.WriteLine(year);

// Type 4 

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//
//    while (i < count)
//   {
//        result = result + text;
//        i++;
//   }
//     return result;    
//}

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // Иниц счётчика,условие,инкримент
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
//Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j}={i * j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?" ;

// string s = "qwerty"
//             012
// s[3] // r

// string Replace(string text, char oldValue, char newValue) // Функция принимающая текст и заменяющая старый на новый символы 
// {
//     string result = String.Empty; // инициализация пустой строки

//     int length = text.Length; // обращение к свойчтву показывающему количесвто символов в строке 
//     for ( int i = 0; i < length; i++) //цикл
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}"; // замена на новый символ 
//         else result = result + $"{text[i]}"; // 

//     }
//     return result; // возврат результата выполнения функции 
// }

// string newText = Replace(text, ' ', '|'); // вызов функции (переменная обознач текс,старый символ,новый символ)
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);

int [] arr = {6,4,5,3,2,7,1,3,5,8};

void PrintArray(int[] array) // Метод для печати массива 
{
    int count = array.Length; // Переменная обозначающая длину массива 
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] array) // Метод для сортировки чисел
{
    for(int i = 0; i < array.Length ; i++)
    {
        int minPosition = i; // предполагаем что минимальный элемент - первый

        for(int j = i + 1; j < array.Length; j++) // Цикл для перебора оставшихся неотсортированных элементов 
        {
            if(array[j] < array[minPosition]) minPosition = j; // поиск индекса минимального из оставшихся элементов 

        }

        int temporary = array[i]; // временная переменная для запоминания текущеэлемента 
        array[i] = array[minPosition]; // замена текущего элемента на новый найденный минимальный 
        array[minPosition] = temporary; // переносим текущий жлемент за место найденного минимального 

    }

}

void SelectionSortMax(int[] array) // Метод для сортировки чисел
{
    for(int i = 0; i < array.Length ; i++)
    {
        int maxPosition = i; // предполагаем что максимальный элемент - первый

        for(int j = i + 1; j < array.Length; j++) // Цикл для перебора оставшихся неотсортированных элементов 
        {
            if(array[j] > array[maxPosition]) maxPosition = j; // поиск индекса максимальный из оставшихся элементов 

        }

        int temporary = array[i]; // временная переменная для запоминания текущеэлемента 
        array[i] = array[maxPosition]; // замена текущего элемента на новый найденный максимальный
        array[maxPosition] = temporary; // переносим текущий жлемент за место найденного максимальный

    }

}


PrintArray (arr);
SelectionSortMax(arr);

PrintArray (arr);




