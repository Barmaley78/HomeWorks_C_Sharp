/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int message = int.Parse(Console.ReadLine());
    return message;
}

int numCount(int m)
{
    int Count = 0;
    for (int i = 0; i < m; i++)
    {
        if(GetNumber("Введите число ") > 0) Count++;
    }
    return Count;
}
int k = GetNumber("Введите количество чисел ");
Console.WriteLine($"Количество положительных чисел {numCount(k)}");