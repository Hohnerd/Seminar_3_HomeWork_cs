// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("");
Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());

for(int x=1;x<=number; x++)
{  
    Console.WriteLine("---------+---------");
       
    Console.WriteLine("|  " +x + "\t | " + x*x*x + "\t  |");
} 

