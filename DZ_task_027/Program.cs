// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!"); 
int sum = GetSumDigit(num);
Console.WriteLine($"Сумма чисел {num} равна -> {sum}");

int GetNumberFromUser(string message, string errorMessage) 
{     
    while(true)     
    {         
    Console.Write(message);          
        if(int.TryParse(Console.ReadLine(), out int userNumber))            
        return userNumber;          
        Console.WriteLine(errorMessage);     
    } 
} 

int GetSumDigit(int num)
{
    int sum = 0;
    while(num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
    return sum;
}
