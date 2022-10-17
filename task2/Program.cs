// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
//452 -> 11
//82 -> 10
//9012 -> 12


int SumNumber(int n)
{
    if (n < 0)
    {
        n = -n;
    }
    int sum = 0;
    while (n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    return sum;
}

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int sumNum = SumNumber(a);
Console.WriteLine($"Сумма цифр числа {a} равна {sumNum}");
