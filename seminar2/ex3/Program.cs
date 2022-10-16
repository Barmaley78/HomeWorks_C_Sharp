// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int GetNumber(string mess)
{
    Console.WriteLine(mess);
    string numStr = Console.ReadLine();
    int num = int.Parse(numStr);
    return num;
}

int num1 = GetNumber("Введите 1-е число ");
int num2 = GetNumber("Введите 2-е число ");
int res = num1 % num2;
if(res == 0)
    Console.WriteLine("числа кратные");
else
    Console.WriteLine($"числа не кратные, отстаток от деления {res}");
