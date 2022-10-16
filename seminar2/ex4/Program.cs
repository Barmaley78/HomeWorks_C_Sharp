// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int GetNumber(string mess)
{
    Console.WriteLine(mess);
    string numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    return num;
}

int num1 = GetNumber("Введите число ");
if(num1 % 23 == 0 && num1 % 7 == 0)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");