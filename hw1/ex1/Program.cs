Console.WriteLine("Введите два числа");
string num1Str = Console.ReadLine();
string num2Str = Console.ReadLine();
int num1 = int.Parse(num1Str);
int num2 = int.Parse(num2Str);
if(num1 > num2)
{
    Console.WriteLine($"max = {num1} min = {num2}");
}
else
if(num1 < num2)
{
    Console.WriteLine($"max = {num2} min = {num1}");
}
else
{
    Console.WriteLine($"{num1} = {num2}");
}

