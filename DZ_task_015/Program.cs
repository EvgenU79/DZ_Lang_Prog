// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

int varA;

while (true)
{
    Console.WriteLine ("Введите день недели от 1 до 7");
    if (int.TryParse(Console.ReadLine(), out varA))
    break;
    Console.WriteLine("false");
}
if (varA == 6 || varA == 7)
{
    Console.WriteLine($"{varA} -> День недели выходной");
}
else
{
    Console.WriteLine($"{varA} -> День недели невыходной");
}
