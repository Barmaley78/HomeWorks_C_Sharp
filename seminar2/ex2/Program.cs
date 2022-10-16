Random rnd = new Random();
int num = rnd.Next(100, 1000);
Console.WriteLine($"Случайное число {num}");
int result = (num / 100) * 10 + num % 10;
Console.WriteLine($"результат {result}");