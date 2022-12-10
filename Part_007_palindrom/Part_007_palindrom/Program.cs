//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите число для проверки палиндрома: ");
string number = Console.ReadLine();
     int b = number.Length-1;
for (int i = 0; i < number.Length; i++)
{
        if (number[i] == number[b])
    { 
        b = b-1;
    }      
    else
    { 
        Console.WriteLine($"{number} Не является полиндромо");
    break;
    }
    Console.WriteLine("является полиндром");
}



