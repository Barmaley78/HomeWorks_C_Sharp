// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число А: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int n = num;

while(n % 10 != 0) 
{
    sum++;
    n = n / 10;
}
Console.WriteLine($"в числе {num} {sum} цифры");
