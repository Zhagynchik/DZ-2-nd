﻿/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


Console.WriteLine($"Введите трехзначное число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int secondDigit = number / 10 % 10;
Console.WriteLine(secondDigit);



