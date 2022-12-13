/* Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B.
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()
 */


int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите число B: ");
Exponentiation(A, B);

void Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
