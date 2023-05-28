// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29.

Console.Clear();
int n = GetValueFromUser("Введите первое число: ", "Ошибка ввода!Повторите попытку!");
int m = GetValueFromUser("Введите второе число: ", "Ошибка ввода!Повторите попытку!");
int result = Akkerman(n, m);
Console.WriteLine($"Функция Аккермана -> {result} ");

////////////////////////////////////////  
int GetValueFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userValue))
            return userValue; Console.WriteLine(errorMessage);
    }
}
int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Akkerman(n - 1, 1);
    return Akkerman(n - 1, Akkerman(n, m - 1));

}
