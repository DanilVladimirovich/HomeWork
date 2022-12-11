float[] GetArray(int length)
{
    float[] array = new float[length];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число дробные вводятся через (,): ");
        array[i] = float.Parse(Console.ReadLine());
    }
    return array;
}
string GetArrayAsString(float[] array)
{
    string s = string.Empty;
    foreach (var item in array) { s += $"[{item}] "; }
    return s;
}

void CheckArray(float[] mass)
{
    float min = mass[0];
    float max = mass[1];
    float sum = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max)
        {
            max = mass[i];
        }
        else if (mass[i] < min)
        {
            min = mass[i];
        }
        sum = max - min;
    }
    Console.WriteLine($"Разница между Максимальным и Минимальным числом {max} - {min} = {sum}");
}

float[] massiv = GetArray(4);
Console.WriteLine(GetArrayAsString(massiv));
Console.WriteLine();
CheckArray(massiv);


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76