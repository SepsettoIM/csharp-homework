﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(number);
if (Number.Length > 2)
{
  Console.WriteLine("третья цифра -> " + Number[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}