// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void Sqare(int n)
{
    for(int i = 1; i <= n; i++)
    {
        if(i!=n)
        Console.Write($"{i*i}, ");
        else Console.Write($"{i*i} ");
    }
}

int GetNum(string mess)
{
    int result;
    while (true)
    {
        Console.WriteLine(mess);
        if(int.TryParse(Console.ReadLine(), out int num))
        {
            result = num;
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. повторите ввод \n");
        }
    }
    return result;
}

int num = GetNum("Введите число ");
Sqare(num);