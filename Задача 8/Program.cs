﻿//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все четные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine()!); 
int i = 1;
while (i <= N)
{
    if (i%2 == 0)
    Console.WriteLine(i);
   i = i+1;
}
