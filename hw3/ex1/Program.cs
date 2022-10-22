// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetNum(string mess)
{
    int result = 0;
        while (true)
    {
        Console.WriteLine(mess);
        string str = Console.ReadLine();
        if(int.TryParse(str, out int num) && Math.Abs(int.Parse(str)) / 10000 > 0 && Math.Abs(int.Parse(str)) / 10000 < 10) 
        {
            result = Math.Abs(int.Parse(str));
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не пятизначное число \n");
        }
    }
    return result;
}

void poliCheck(int[] num)
{
    if(num[0] == num[4] && num[1] == num[3]) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

int number = GetNum("Введите пятизначное число");
int[] arr = new int[5];
for(int i = 4; i >= 0 ; i--)
{
    arr[i] = number % 10;
    number = number / 10;
}
poliCheck(arr);