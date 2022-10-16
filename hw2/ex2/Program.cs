Console.WriteLine("Введите число ");
string numStr = Console.ReadLine();
int num = Math.Abs(int.Parse(numStr));
int res = num / 100;
if(res > 0)
    Console.WriteLine($"Третья цифра числа {res % 10}");
else
    Console.WriteLine($"Третья цифра в числе отсутсвует");
