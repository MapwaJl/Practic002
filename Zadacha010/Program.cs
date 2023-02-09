// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine ()!); 
int a1 = num / 10;

int result = a1 % 10;

Console.WriteLine($"Трехзначное число : {num}, Вторая цифра равна {result}");