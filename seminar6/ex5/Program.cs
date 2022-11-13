/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с 
помощью поэлементного копирования.
*/

int[] InitArray()
{
    Random rnd = new Random();
    int k = rnd.Next(5,11);
    int[] result = new int[k];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(0,10);
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

int[] CopyArray(int[] ar)
{
    int[] res = new int[ar.Length];
    for (int i = 0; i < ar.Length; i++)
        res[i] = ar[i];
    return res;
}

int[] a = InitArray();
PrintArray(a);
Console.WriteLine();
PrintArray(CopyArray(a));

/*
T[] Copy<T> (T[] array)
{
    T[] result = new T[array.Length];
    return result;
}

одна реализация для любого типа данных 

*/

AllType[] Copy<AllType> (AllType[] array)
{
    AllType[] result = new AllType[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

string[] strArray = new string[3] {"1","2332","fdfdf"};
int[] intArray = new int[3]{1,2,3};
bool[] boolArray = new bool[3]{true, false, false};

string[] resStrArray = Copy(strArray);
int[] resIntArray = Copy(intArray);
var resBoolArray = Copy(boolArray);


