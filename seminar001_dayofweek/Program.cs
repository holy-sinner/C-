Console.Clear();

Console.Write("Введите цифру дня недели  : ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);


if(userNumber == 1 )
{
 Console.WriteLine("Понедельник день тяжёлый((");
}
if(userNumber == 2 )
{
 Console.WriteLine("Охх, уже вторник");
}
if(userNumber == 3 )
{
 Console.WriteLine("Среда, почти половина недели позади");
}
if(userNumber == 4 )
{
 Console.WriteLine("Четверг, ну еще чуть-чуть осталось ");
}
if(userNumber == 5 )
{
 Console.WriteLine("Ура, пятницв! Надо сегодня нажраться))");
}
if(userNumber == 6 )
{
 Console.WriteLine("Суббота, ох отосплюсь же я сегодня!");
}
if(userNumber == 7 )
{
 Console.WriteLine("Воскресенье, люблю воскресенье))");
}
else
{
 Console.WriteLine("Ты что-то ввёл неверно))");
}