using System.Diagnostics.CodeAnalysis;

int ReadInt ()
{
    string s = Console.ReadLine();
    if (int.TryParse(s, out int i))
        return i;
    return -1;
}

int[] GetArray(int linght)
{
    int[] massiv = new int[linght];
    for (int  i = 0; i < massiv.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        massiv[i] = ReadInt();
    }
    return massiv; 
}

string PrintArray(int[] mass)
{
    string a = string.Empty;
    foreach(var item in mass) { a += $"[ {item} ] "; }
    return a;   
}

int GetCount(int[] count)
{
    int sum = 0;
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i]>0)
        {
            sum ++; 
        }
    }
    return sum;
}


void Task41()
{ 
Console.WriteLine("Введине количество элементов в массиве: ");
int[] array = GetArray(ReadInt());
Console.WriteLine(PrintArray(array));
Console.WriteLine($"Количество положительных чисел: {GetCount(array)}");
}

Task41();



//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3