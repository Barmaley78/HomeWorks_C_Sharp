
int GetNumber(string mess)
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

int GetXY(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    else 
    if(x < 0 && y > 0) return 2;
    else 
    if(x < 0 && y < 0) return 3; 
    else return 4;
}
int numX = GetNumber("Введите X ");
int numY = GetNumber("Введите Y ");
int Q = GetXY(numX, numY);
Console.WriteLine($"точка с координатами ({numX} {numY} находится в {Q} четверти)");