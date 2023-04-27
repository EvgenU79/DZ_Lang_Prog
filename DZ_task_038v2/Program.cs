// // Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int length = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода! ");

double[] array = GetArray(length);
Console.WriteLine(String.Join(", ", array));
double maxElement = GetFindMax(array);
double minElement = GetFindMin(array);

Console.WriteLine($"Разница между MAX ({maxElement}) и MIN ({minElement}) = {maxElement - minElement}");

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

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble()*100);
    }
    return res;
}

double GetFindMax(double [] array)
{
 double maxElement = array[0];
    for (int i = 1; i < length; i++) 
    {
        if (array[i] > maxElement) 
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

double GetFindMin (double [] array)
{
 double minElement = array[0];
    for (int i = 1; i < length; i++) 
    {
        if (array[i] < minElement) 
        {
            minElement = array[i];
        }
    }
    return minElement;
}
