// Console.WriteLine("Введите число ");
// string numStr = Console.ReadLine();
// int num = Math.Abs(int.Parse(numStr));
// int res = num / 100;
// if(res > 0)
//     Console.WriteLine($"Третья цифра числа {res % 10}");
// else
//     Console.WriteLine($"Третья цифра в числе отсутсвует");

Console.WriteLine("Введите число ");
string numStr = Console.ReadLine();
int num = Math.Abs(int.Parse(numStr));
int[] arr = new int[numStr.Length];
for(int i = numStr.Length - 1; i >= 0 ; i--)
{
    arr[i] = num % 10;
    num = num / 10;
}
if(numStr.Length > 3) Console.WriteLine($"третья цифра {arr[2]}");
else Console.WriteLine($"нет третьей цифры");