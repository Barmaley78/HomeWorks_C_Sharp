/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А 
в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int DegreeOfDigit(int numA, int numB)
{
    if(numB == 1) return numA;
    else
    {
        return numA * DegreeOfDigit(numA, numB - 1);
    }
}    

int userNumberA = GetNumber("Введите число A: ");
int userNumberB = GetNumber("Введите число B: ");
int res = DegreeOfDigit(userNumberA, userNumberB);
Console.WriteLine(res);