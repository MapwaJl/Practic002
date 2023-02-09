// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите число от 1 до 7:");
int num = int.Parse(Console.ReadLine ()!); 

if(num > 5)
{
    Console.WriteLine($"Является выходным днём");
}
else
{
    Console.WriteLine($"День недели : {num} - является будним");
}

