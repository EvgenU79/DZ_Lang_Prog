// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GetRandomArray(5); 
PrintArray(array);
int count = FindEvenNumber(array);
Console.WriteLine($"В данном массиве {count} четных чисел");

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

int FindEvenNumber(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el %2 ==0)
            count++;
    }
    return count;
}