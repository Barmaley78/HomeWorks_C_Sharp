// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int GetNumber(string msg)
{
    Console.Write(msg);
    int message = Convert.ToInt32(Console.ReadLine());
    return message;
}

/*
string Conv(int num)
{
    string res = String.Empty;
    while(num >=2)
    {
        int s = Convert.ToString(num % 2);
        res = string.Insert(1, s);
        num = num / 2;
    }
    int s = Convert.ToString(num % 2);
    res = string.Insert(1, s);
}
*/

string Conv(int num)
{
    string res = String.Empty;
    while(num != 0)
    {
        res += num % 2;
        num = num / 2;
    }
    return res;
}

string Rev(string a)
{
    string sA = new string(a.Reverse().ToArray());
    return sA;
}

int n = GetNumber("Введите число ");
string res = Conv(n);
res = Rev(res);
Console.WriteLine($"{n} в двоичной форме равно {res}");