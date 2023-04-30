//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


int length = Prompt("Введите длину массива: ");
int[] array = InputArray(length);

Console.WriteLine(String.Join(", ", array));
int count = FindPositivNumbers(array);
Console.WriteLine($"Колличество положительных элементов = {count}");

//////

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i+1}-й элемент - ");
    }
    return array;
}

int FindPositivNumbers(int []array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0)
    count++;
  }
    return count;
}