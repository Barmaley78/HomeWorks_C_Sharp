﻿Console.WriteLine("Введите число А: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

for(int i = 1; i <= num; i++)
{
    sum += i;
}

Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");