﻿Console.Write("Возвести число в куб: ");
double number = int.Parse(Console.ReadLine());
double n = number;
for (int i = 1; i <= number; i++)
{
    n = Math.Pow(i, 3);
    Console.WriteLine($"{i} = {n}");   
}


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
