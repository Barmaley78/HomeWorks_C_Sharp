double GetDis3D(Point firstPoint, Point secondPoint) 
{
    double distance3D = Math.Sqrt(
        Math.Pow(firstPoint.X - secondPoint.X, 2)
        +Math.Pow(firstPoint.Y - secondPoint.Y, 2)
        +Math.Pow(firstPoint.Z - secondPoint.Z, 2));

    return distance3D; 
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

Point GetPoint()
{
    Point point = new Point();

    point.X = GetNumber("ВВедите кординаты для x");
    point.Y = GetNumber("ВВедите кординаты для y");
    point.Z = GetNumber("ВВедите кординаты для z");

    return point;
}

Point firstPoint = GetPoint();
Point secondPoint = GetPoint();
double distance = GetDis3D(firstPoint, secondPoint);

Console.WriteLine($"Расстояние между точками равно = {distance}");


class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
}

//первым возращаем максимальный, вторым минимальный
// (int, int) GetMaxAndMinTemp(int [] array)
// {
//     int max = array[0];
//     int min = array[0];

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(min > array[i])
//             min = array[i];

//         if(max < array[i])
//             max = array[i];
//     }

//     return (max, min);
// }

// var array = new int[10];
// var rnd = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(1,10);
// }


// (int max, int min) = GetMaxAndMinTemp(array);
// 