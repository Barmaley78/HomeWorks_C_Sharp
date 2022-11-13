// матрица m  на n заполненная случайно

void PrintArray(int[,] m)
{
    for(int i = 0; i < m.GetLength(0); i++)
    {
        for(int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write($"{m[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] m)
{

    for(int i = 0; i < m.GetLength(0); i++)
    {
        for(int j = 0; j < m.GetLength(1); j++)
        {
            m[i, j] = new Random().Next(-100,101);
        }
    }
}

int GN(string mes)
{
    Console.WriteLine(mes);
    int res = int.Parse(mes);
    return res;
}

int m = GN("Введите m");
int n = GN("Введите n");
int[,] matr = new int[int m, int n];
FillArray(matr);
PrintArray(matr);


int GetNumber(string msg)
{
    Console.Write(msg);
    int message = Convert.ToInt32(Console.ReadLine());
    return message;
}

void Check(int a, int b, int c)
{
    if(a < (b + c) && b < (a + c) && c<(a + b))
    Console.WriteLine("Такой треугольник существует");
    else 
    Console.WriteLine("Такой треугольник НЕ существует");
}


int numberA = GetNumber("Введите первое число:");
int numberB = GetNumber("Введите второе число:");
int numberC = GetNumber("Введите третье число:");

Check(numberA, numberB, numberC);