﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void WeekDays (int number) 
{
  if (number == 6 || number == 7) 
  {
  Console.WriteLine("Этот день выходной -> да");
  }
  else if (number < 1 || number > 7) 
  {
    Console.WriteLine("Введите день от 1 до 7");
  }
  else Console.WriteLine("Этот день не выходной -> нет");
}

WeekDays(number);