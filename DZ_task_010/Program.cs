﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("Введите трехзначное целое число: ");

int N = int.Parse(Console.ReadLine() ?? "");
int a1 = N / 10;
int a2 = a1 % 10;

Console.WriteLine ($"Вторая цифра числа {N}  -> {a2}");
