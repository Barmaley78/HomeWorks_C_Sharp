// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int[] InitArray()
{
    int[] result = new int[3];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(Console.ReadLine());
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int max(int[] ar)
{
    inr res = 0;
    for (int i = 1; i < ar.Length; i++)
    {
        if(ar[res] < ar[i]) res = i;
    }
    return res;
}