// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Задает = считыват с клавиатуры? или случайным образом?

int[] arr = new int[8];
Random rnd = new Random();
Console.Write("[");
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 100);
    if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
    else Console.WriteLine($"{arr[i]}]");
}