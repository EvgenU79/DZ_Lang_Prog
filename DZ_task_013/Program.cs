// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine ("Введите целое число: ");
    
int N = int.Parse(Console.ReadLine() ?? "");
string str = N.ToString();
if (N < 100)
{
    Console.WriteLine("Это не трехзначное число!!!");
}
else
{
    Console.WriteLine($"Третья цифра {N} -> {str[2]}");
}


