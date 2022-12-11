int[] Massiv(int length)
{
    int[] mass = new int[length];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }
    return mass;    
}

void CheckArray(int[] mass)
{
    int number = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            number ++;
        }
        else
        {
            number += 0;
        }
    }
    Console.WriteLine($"Количество четных чисен в Массиве: {number}"); 
}

string GetArray(int[] array)
{ 
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]},  ";
    }
    return result;
}

int[] massiv = Massiv(10);
Console.WriteLine(GetArray(massiv));
Console.WriteLine();
CheckArray(massiv);




//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
