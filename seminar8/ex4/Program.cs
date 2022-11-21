/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. */

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

int[,] InitArray(int m, int n)
{
    int [,] tempArray = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(0, 100);
        }
    }

    return tempArray;
}

void PrintArray(int [,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

(int i, int j) GetMinElementIndexes(int [,] array)
{
    int min = -1;
    int resI = 0;
    int resJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(min > array[i,j])
            {
                min = array[i,j];
                resI = i;
                resJ = j; 
            }
        }
    }
    return(resI, resJ);
}

int[,] TranspArray(int[,] array)
{
    int[,] resArray = new int[array.GetLength(1),array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resArray[i,j] = array[j,i];
        }
    }
    return resArray;
}


int m = GetNumber("Введите число строк: ");
int n = GetNumber("Введите число столбцов: ");
int[,] array = InitArray(m, n);
PrintArray(array);
Console.WriteLine();
int[,] resArray = TranspArray(array);
PrintArray(resArray);

