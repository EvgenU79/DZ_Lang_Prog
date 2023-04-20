// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.


int num = GetNumberFromUser("Введите пятизначное число: ", "Ошибка ввода! ");

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

int r;
int sum = 0;
int t;

if(num>9999 && num<100000)
{
    for(t=num;num!=0;num=num/10)
{
    r=num % 10;
    sum=sum*10+r;
}
    if(t==sum)
     Console.Write($"{t} является палиндромом.");
    else
    Console.Write($"{t} не является палиндромом.");
} 
else
Console.Write("Введите пятизначное число!");