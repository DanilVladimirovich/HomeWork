int[] GetArray(int length) 
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt();
    }
    return array;
}
string GetArrayAsString(int[] array)
{
    string s = string.Empty;
    foreach (var item in array) { s += $"[{item}] "; }
    return s;
}

int ReadInt()
{
    Console.WriteLine("Введите число: ");

    if (int.TryParse(Console.ReadLine(), out int i)) 
    {
        return i;
    }

    Console.WriteLine("Это не число: ");

    return -1;
}

int[] massiv = GetArray(8); 
Console.WriteLine(GetArrayAsString(massiv));

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33-> [6, 1, 33]


