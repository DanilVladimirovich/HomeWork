Console.Write("Введите значение: ");
int i = int.Parse (Console.ReadLine());
if (i <= 99)
{
    Console.WriteLine("нет третьего символа: ");
}
else
{ 
string s1 = i.ToString();
    Console.WriteLine(s1[2]);
}


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
