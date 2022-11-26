/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */


int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

string perebor(int num)
{
    string str = string.Empty;
    if (num == 1) return num.ToString();
    return perebor(num - 1) + " " + num;
}

int m = GetNumber("Введите число строк: ");
Console.WriteLine();
Console.WriteLine(perebor(m));