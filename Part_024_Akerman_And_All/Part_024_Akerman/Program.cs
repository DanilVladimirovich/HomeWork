void Task(int number)
{
    int n = number;
    switch (n)
    {
        case 1:Task64(); break;
        case 2:Task66(); break;
        case 3:Task68(); break;

        default: Console.WriteLine("Такого задания нет"); break;
    }
}
Console.WriteLine("Введите (1) для задачи #64");
Console.WriteLine("Введите (2) для задачи #66");
Console.WriteLine("Введите (3) для задачи #68");
Task(ReadInt());


int ReadInt()
{
    Console.WriteLine("Введите не отрицательное целое число: ");
    string s = Console.ReadLine();

    if (int.TryParse(s, out int i))
        return i;

    return -1;
}


void Task68()
{ 
    int AckermannFunction(int numberM, int numberN)
    {
        if (numberM == 0) return numberN + 1;
        if (numberM > 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
        if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
        return AckermannFunction(numberM, numberN);
    }
    Console.WriteLine("Вводите числа для функции Акермана!");
Console.WriteLine($"A(m,n) = {AckermannFunction(ReadInt(), ReadInt())}");

    //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    //m = 2, n = 3->A(m, n) = 9
    //m = 3, n = 2->A(m, n) = 29
}

void Task64()
{ 
    string MetodRecursionNumbers(int a, int b)
    {
        if (a <= b) return MetodRecursionNumbers(a + 1, b) + $"{a} ";
        else return string.Empty;
    }
    Console.WriteLine("Порядок чисел в обратной последовательности. Вводите числа от минимальной к максимальной!");
    Console.WriteLine($"Введите число от и до: {MetodRecursionNumbers(ReadInt(), ReadInt())}");
    
    
    //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

    //N = 5 -> "5, 4, 3, 2, 1"
    //N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
}


void Task66()
{ 
    void SumElement(int numberone, int numbertow)
    {
        int sum = numberone;
            while (numberone < numbertow)
            {
                  sum = sum + (numberone + 1);
                   numberone++;
            Console.WriteLine(sum);
            }
        Console.WriteLine($"Сумма = {sum}");
    }
    Console.WriteLine("Находит сумму всех чисел в промежутке от и до. Вводите числа минимальное максимальное!");
    SumElement(ReadInt(), ReadInt());

    //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    //M = 1; N = 15-> 120
    //M = 4; N = 8. -> 30
}









