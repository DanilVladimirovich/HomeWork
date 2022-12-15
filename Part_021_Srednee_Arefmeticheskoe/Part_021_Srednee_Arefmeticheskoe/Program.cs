int[,] TwoDementionArray(int lenght, int secondlenght)
{
    Random random = new Random();
    int[,] array = new int[lenght, secondlenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 30);

        }
    }
    return array;
}

int ReadInt()
{
    Console.WriteLine("Input number");
    int a = int.Parse(Console.ReadLine());
    return a;
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

decimal GetColum(int[,] massive, int colum)
{
    decimal sum = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        sum += massive[i,colum];
    }
    return sum / massive.GetLength(0);
}
 

int[,] array = TwoDementionArray(ReadInt(), ReadInt());
Console.WriteLine();
GetArrayAsString(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(1); i++)
{
    Console.WriteLine($"{i} --- {GetColum(array, i)}");
}



//Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.