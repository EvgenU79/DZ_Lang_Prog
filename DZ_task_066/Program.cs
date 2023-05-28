// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

Console.Clear();
int firstNumb = GetValueFromUser("Введите первое число: ", "Ошибка ввода!Повторите попытку!");
int secondNumb = GetValueFromUser("Введите второе число: ", "Ошибка ввода!Повторите попытку!");
int result = GetSumm(firstNumb, secondNumb); 
Console.WriteLine(result);

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
int GetSumm(int numb1, int numb2)
{
    if (numb1 == numb2) return numb1;//завершаем цикл когда последнее число равно первому
    return numb1 + GetSumm(numb1 + 1, numb2);
}

