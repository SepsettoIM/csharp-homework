// Задача №8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int start = 2;

if(number > 1)
{
    while(start <= number)
    {
        Console.Write(start + " ");
        start = start + 2;
    }
}