Console.Write("Введите число ");
string numStr = Console.ReadLine();
int num = int.Parse(numStr);
if(num % 2 == 0)
{
    Console.WriteLine($"Число {num} четное");
}
else
{
    Console.WriteLine($"Число {num} нечетное");
}