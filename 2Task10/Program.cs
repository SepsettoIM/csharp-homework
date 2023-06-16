// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
string Number = Convert.ToString(number);
Console.WriteLine("второе число -> "+Number[1]);