// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру.
// Console.Clear();
// // 100 // 1000

// int num = new Random().Next(100, 1000);
// int a1 = num / 100;
// int a2 = num % 10;

// int result = a1 * 10 + a2;

// Console.WriteLine($"Трехзначное число : {num}, Результат задачи : {result}");


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе кратным пермому. Если 2 число не кратно 1,то выводится остаток деления
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine ()!); 
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine ()!); 
int ost = b % a;
if (ost != 0)
{
    Console.WriteLine($" Не кратно, остаток равен {ost}");
}
Console.WriteLine($"Кратно");
