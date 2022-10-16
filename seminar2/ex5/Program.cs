// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int GetNumber(string mess)
{
    Console.WriteLine(mess);
    string numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    return num;
}

int num1 = GetNumber("Введите 1-е число ");
int num2 = GetNumber("Введите 2-е число ");
if(num2 < num1)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
if(num1 * num1 == num2)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
