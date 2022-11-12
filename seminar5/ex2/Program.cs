//Задача 32: Напишите программу замена элементов массива: положительные
// элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] InitArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9,10);
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

int[] InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

Console.WriteLine("Введите длину массива ");
int d = int.Parse(Console.ReadLine());

int[] a = InitArray(d);
PrintArray(a);
int[] b = InvertArray(a);
PrintArray(b);