﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int DivRem = number % 2;

if(DivRem == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
