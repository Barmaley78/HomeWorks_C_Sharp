//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
//число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

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

void ArraySearch(int[] array, int s)
{
    string qqq = "нет";
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == s)
            {
                qqq = "Да";
                break;
            }
   }
   Console.WriteLine(qqq);
}

Console.WriteLine("Введите длину массива ");
int d = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число для поиска ");
int ser = int.Parse(Console.ReadLine());

int[] a = InitArray(d);
PrintArray(a);
ArraySearch(a, ser);