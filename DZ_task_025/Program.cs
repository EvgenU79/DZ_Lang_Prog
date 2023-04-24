// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Console.Clean();  
int num1 = GetNumberFromUser("Введите целое число - основание: ", "Ошибка ввода!"); 
int num2 = GetNumberFromUser("Введите целое число - степень: ", "Ошибка ввода!"); 
int stepen = GetExponentiate(num1, num2);
Console.WriteLine($"Число {num1} в степини {num2} равно -> {stepen}");

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

int GetExponentiate(int num1, int num2)
{
   int stepen = 1;
    for (int i = 0; i < num2; i++)
    {
        stepen*=num1;
    } 
    return stepen;
}


