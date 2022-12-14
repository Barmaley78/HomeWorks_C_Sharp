// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

double GetDist(int x1, int y1, int z1, int x2, int y2, int z2)
{
   double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)); 
    return dist;
}

int GetNum(string mess)
{
    int result;
    while (true)
    {
        Console.WriteLine(mess);
        if(int.TryParse(Console.ReadLine(), out int num))
        {
            result = num;
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. повторите ввод \n");
        }
    }
    return result;
}

int numX1 = GetNum("Введите координату X 1 точки ");
int numY1 = GetNum("Введите координату Y 1 точки ");
int numZ1 = GetNum("Введите координату Z 1 точки ");
int numX2 = GetNum("Введите координату X 2 точки ");
int numY2 = GetNum("Введите координату Y 2 точки ");
int numZ2 = GetNum("Введите координату Z 2 точки ");

double res = GetDist(numX1, numY1, numZ1, numX2, numY2, numZ2);
Console.WriteLine($"Расстояние между точками ({numX1}, {numY1}, {numZ1}) и ({numX2}, {numY2}, {numZ2}) составляет {Math.Round(res, 2)}");
