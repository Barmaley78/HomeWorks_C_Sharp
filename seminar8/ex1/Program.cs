/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
   и последнюю строку массива. */

int[,] InitArray(int m, int n)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArrayStrings(int[,] array, int strChange, int strToChange)
{
    int [,] resArray = new int[array.GetLength(0), array.GetLength(1)];
    resArray = array;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        resArray[strToChange,i] = array[strChange,i];
        resArray[strChange,i] = array[strToChange,i];
    }    
    return resArray;
}

Console.WriteLine("Введите размер m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размер n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = InitArray(m, n);
PrintArray(array);

Console.WriteLine();
int[,] resultArray = ChangeArrayStrings(array, 0, array.GetLength(1) - 1);
PrintArray(resultArray);