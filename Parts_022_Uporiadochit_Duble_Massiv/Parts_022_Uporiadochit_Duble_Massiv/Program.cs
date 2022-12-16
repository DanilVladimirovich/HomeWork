using System.Globalization;

int[,] TwoDementionArray(int lenght, int secondlenght)
{
    Random random = new Random();
    int[,] array = new int[lenght, secondlenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(15);

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
void GetChenge(int[,] array)
{
    int rows = array.GetLength(0);
    int colns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colns; j++)
        {
            for (int k = j+1; k < colns; k++)
            {
                if (array[i,k]> array[i,j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;

                }
            }         
            
        }         
                       
    }   
}



int[,] array = TwoDementionArray(ReadInt(), ReadInt());
GetArrayAsString(array);
Console.WriteLine();
GetChenge(array);
GetArrayAsString(array);

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2




