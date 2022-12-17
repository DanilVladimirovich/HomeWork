using System.Diagnostics.CodeAnalysis;

int[,] TwoDementionArray(int lenght, int secondlenght)
{
    Random random = new Random();
    int[,] array = new int[lenght, secondlenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(50);

        }
    }
    return array;
}

int ReadInt()    
{
    Console.WriteLine("Введите число: ");
    string s = Console.ReadLine();

    if (int.TryParse(s, out int i))
        return i;

    return -1;
}

void GetArrayAsString(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}
void GetSumLine(int[,] array)
{
    int line = array.GetLength(0);
    int colns = array.GetLength(1);
    int k = 0;
    int min = 0;
    int b = 0;
    int index = 0;
    int[] sum = new int[line];
    for (int i = 0; i < line; i++)
    {
        min = 0;
        for (int j = 0; j < colns; j++)
            {
            if (i == k)
                {
                    min += array[i, j];
                    sum[k] = min;
                
                }             
            }
        k++;
    }
    for (int l = 0; l < sum.Length; l++)
    {
        if (min >= sum[l])
        {
            min = sum[l];
            b = l+1;
            index = l;
        }
    }
    Console.WriteLine($"Наименьшая сумма в строке -- {b} -- под индексом {index} сумма всех чисел = {min}");    
}


int[,] array = TwoDementionArray(ReadInt(), ReadInt()); 
GetArrayAsString(array);
Console.WriteLine();
GetSumLine(array);


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
