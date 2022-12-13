/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/


int number = ReadInt("Введите число: ");

int count = MethodOfCountingDigitsInNumber(number);

MethodOfDisplayingSumOfDigitsInNumber(number, count);

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int MethodOfCountingDigitsInNumber(int a)
{
    int index = 0;
    while (a > 0)
    {
        a = a / 10;
        index++;
    }
    return index;
}

void MethodOfDisplayingSumOfDigitsInNumber (int n, int count)
{
    int sum = 0;
    for (int i = 1; i <= count; i++)
    {
        sum = n % 10 + sum;
        n = n / 10;
    }
    Console.WriteLine(sum);
}