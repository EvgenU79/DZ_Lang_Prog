// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число: ");
int N = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("все чётные числа от 1 до N");
for (int i = 2; i <= N; i = i + 2)
{
    Console.Write(i + " ");
}