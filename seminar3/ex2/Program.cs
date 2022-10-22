// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int GetNum(string mess)
{
    int result;
    while (true)
    {
        Console.WriteLine(mess);
        if(int.TryParse(Console.ReadLine(), out int num) && num != 0)
        {
            result = num;
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число равное нулю. повторите ввод \n");
        }
    }
    return result;
}

void GQ(int x)
{
    switch (x)
    {
        case 1:
            Console.WriteLine("x>0; y>0");
            break;
        case 2:
            Console.WriteLine("x<0; y>0");
            break;
        case 3:
            Console.WriteLine("x<0; y<0");
            break;
        case 4:
            Console.WriteLine("x>0; y<0");
            break;
        default:
            Console.WriteLine("fffffff");
            break;
    }
}

int x = GetNum("Введите  номер четверти");
GQ(x);