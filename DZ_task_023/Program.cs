// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.


int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода! ");

//////
int GetNumberFromUser(string message, string ErrorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber))
        return userNumber;
        Console.Write(ErrorMessage);
    }
}
/////////////

Console.Write("Таблица кубов:\n");
for (int i=1;i<=num;i++)
{
int k = i*i*i;
Console.Write($"{k}, ");
}