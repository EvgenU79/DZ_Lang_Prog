// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = GetArray(8, 1, 20);
Console.WriteLine(string.Join($" , ", array));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size - 1; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}