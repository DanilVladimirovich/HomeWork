Console.Write("Введите значение: ");
int i = int.Parse (Console.ReadLine());
int j = 10;
if (i > 99 || i < -99)
{
    while (i > 999 || i < -999)
   {
       i = i / j;
    }
    i = i % 10;
    Console.WriteLine(i);
}
else
   Console.WriteLine("нет третьего значения: ");
    

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


//Console.Write("Введите значение: ");
//int i = int.Parse(Console.ReadLine());
//if (Math.Abs(i) <= 99)
//{
  //Console.WriteLine("нет третьего символа: ");
//}
//else
//{
  //string s1 = i.ToString();

    //if (i > 0)
     //Console.WriteLine(s1[2]);
     //
    //else
       // Console.WriteLine(s1[3]);
//}

