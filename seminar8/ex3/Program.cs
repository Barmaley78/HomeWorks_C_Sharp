/* Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит 
информацию о том, сколько раз встречается элемент входных данных.
вход
{ 1, 9, 9, 0, 2, 8, 0, 9 }

выход
0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза */

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
            tempArray[i, j] = rnd.Next(0, 10);
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

(List <int>, List <int>) CalculateArrayVocabury(int[,] array)
{
   /* int vocaburyArray = new int[2,(array.GetLength(0)*array.GetLength(1))];*/

   int flag = 0;
   List <int> elements = new List<int>();
   List <int> numOfElems = new List<int>();
   for (int i = 0; i < array.GetLength(0); i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < elements.Count(); k++)
            {
                if(elements[k] == array[i,j])
                {
                    numOfElems[k] += 1;
                    flag = 1;
                }
            
            }
            if(flag !=1)
                {
                elements.Add(array[i,j]);
                numOfElems.Add(1);
                flag = 0;
                }
        flag = 0;
        }
   }
   return(elements, numOfElems);
}

void PrintList(List <int> inList)
{
    for (int i = 0; i < inList.Count(); i++)
    {
        Console.Write($"{inList[i]} ");
    }
    Console.WriteLine();    
}


int m = GetNumber("Введите число строк: ");
int n = GetNumber("Введите число столбцов: ");
int[,] array = InitArray(m, n);
PrintArray(array);
Console.WriteLine();

(List <int> elements, List <int> NumOfElems) = CalculateArrayVocabury(array);
PrintList(elements);
PrintList(NumOfElems);