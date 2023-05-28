// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M.
//M = 1; N = 5. -> “5, 4, 3, 2, 1"
//M = 4; N = 8. -> “8, 7, 6, 5, 4"

Console.Clear();
int start = GetNumberFromUser("Введите начальное число : ", "Ошибка ввода! ");
int finish = GetNumberFromUser("Введите конечное число : ", "Ошибка ввода! ");

if (finish > start)
{
    string res = PrintNaturalNums(finish, start);
    Console.WriteLine(res);
}
else Console.WriteLine("Ошибка! Конечное значение меньше начальное");


//////
int GetNumberFromUser(string message, string ErrorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.Write(ErrorMessage);
    }
}

string PrintNaturalNums(int finish, int start)
{
    if (start == finish) return start.ToString();
    return finish + " " + PrintNaturalNums(finish - 1, start);
}

