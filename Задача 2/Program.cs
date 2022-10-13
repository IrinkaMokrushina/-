//Напишите программу, которая на вход принимает два числа 
//и выдает, какое число большее какое меньшее.

Console.Clear();
Console.Write("введите число:");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
    if(number1 > number2)
     Console.WriteLine(number1);
    else
     Console.WriteLine(number2);
