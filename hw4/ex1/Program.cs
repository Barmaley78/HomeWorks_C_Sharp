// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int res =1;
for(int i = 1; i <= num2; i++)
{
    res *= num1;
}
Console.WriteLine($"число {num1} в степени {num2} равно {res}");