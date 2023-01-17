 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12
Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine()!);

int SumOfDigits(int N)
{
    int result = 0;
    while( N/10 > 0)
    {
        result  = result+N%10;
        N = N/10;
    }
    return result+N;
}
Console.WriteLine(SumOfDigits(N));