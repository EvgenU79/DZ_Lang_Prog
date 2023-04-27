// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int length = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода! ");
int min = GetNumberFromUser("Введите мин.значение: ", "Ошибка ввода! ");
int max = GetNumberFromUser("Введите макс.значение: ", "Ошибка ввода! ");

int[] array = GetArray(length, min, max);
Console.WriteLine(String.Join(", ", array));
int sum = SumNegativIndex(array);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");

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

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumNegativIndex(int []arr)
{
  int sum = 0;
  
  for (int i = 0; i < array.Length; i++)
  {
    if(i % 2 == 1)
    sum +=array[i];
  }
    return sum;
}