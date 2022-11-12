//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

int[] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < result.length; i++)
    {
        result[i] = rnd.Next(-9,10);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(int, int) GetP(int[] array)
{
    int PosSum = 0;
    int NegSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            PosSum = PosSum + array[i];
        else
            NegSum = NegSum + array[i];
    }
    return (PosSum, NegSum);
}

int[] array = InitArray();
PrintArray(array);
(int PS, int NS) = GetP(array);
Console.WriteLine($" сумма положительных {PS}, сумма отрицательных {NS}");