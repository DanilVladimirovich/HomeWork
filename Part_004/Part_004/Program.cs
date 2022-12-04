Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = N / N;
while (i < N+1)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
