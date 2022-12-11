int[] Massiv(int length)
{
    int[] mass = new int[length];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-99, 100);
    }
    return mass;
}

void CheckArray(int[] mass)
{
    int sum = 0;
        for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            sum = sum + 0;
        }
        else
        {
            sum = sum + mass[i];
        }
    }
    Console.WriteLine($"Сумма нечетных чисел массива равна: {sum}");
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

int[] massiv = Massiv(15);
Console.WriteLine(GetArray(massiv));
Console.WriteLine();
CheckArray(massiv);

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6]-> 0