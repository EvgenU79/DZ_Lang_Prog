// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int m = GetNumberFromUser("Введите число строк 1-й матрицы: ", "Ошибка ввода! ");
int n = GetNumberFromUser("Введите число столбцов 1-й матрицы и строк 2-й: ", "Ошибка ввода! ");
int p = GetNumberFromUser("Введите число столбцов 2-й матрицы: ", "Ошибка ввода! ");


int[,] firstArray = new int[m, n];
GetArray(firstArray);
Console.WriteLine($"Первая матрица:");
PrintArray(firstArray);


int[,] secondArray = new int[n, p];
GetArray(secondArray);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondArray);

int[,] resultArray = new int[m, p];

MultiplyArray(firstArray, secondArray, resultArray);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultArray);

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

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

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

