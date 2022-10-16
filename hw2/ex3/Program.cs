Console.Write("Введите номер дня ");
string dayNumStr = Console.ReadLine();
int dayNum = Math.Abs(int.Parse(dayNumStr));
if(dayNum == 0 || dayNum == 6)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Не выходной");
