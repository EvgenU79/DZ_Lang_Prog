// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size = GetNumberFromUser("Введите кол-во элементов массива: ", "Ошибка ввода! ");
int minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода! ");
int maxValue = GetNumberFromUser("Введите максимальное значение массива: ", "Ошибка ввода! ");

int[] array = GetArray(size, minValue, maxValue);

Console.WriteLine(string.Join($" , ", array));

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

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size - 1; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}