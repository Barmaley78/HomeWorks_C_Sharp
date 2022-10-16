Console.Write("Введите число ");
string numStr = Console.ReadLine();
int num = int.Parse(numStr);
int count = 2;
while(count <= num - ( num % 2 ))
{
Console.Write($"{count} ");
count = count + 2;
}