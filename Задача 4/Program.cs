//Напишите программу, которая принимает на вход три числа
//и выдает максимальное из этих чисел.

Console.Clear();
Console.Write("Введите число:");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;
{
if (number2 > max)
 Console.WriteLine($"max равен {number2}");

if (number3 > max)
 Console.WriteLine($"max равен {number3}");
else
 Console.WriteLine($"max равен {max}");
}



