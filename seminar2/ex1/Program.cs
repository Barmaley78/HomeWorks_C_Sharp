Random rnd = new Random();
int num = rnd.Next(10, 100);

// class myClass
// {
//     public int Next()
//     {
//         return 1;
//     }
//     public int Next(int a)
//     {
//         return 8*a;
//     }
//     public int Next(int a, int b)
//     {
//         return 8*a*b;
//     }
// }
int fd = num / 10;
int sd = num % 10;
if(fd > sd)
    Console.WriteLine($"большая цифра в числе {fd}");
else if(sd > fd)
    Console.WriteLine($"большая цифра в числе {sd}");
else
    Console.WriteLine($"цифры в числе одинаковые");

