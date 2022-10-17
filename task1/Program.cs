// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b >= 0)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Число {a} в степени {b} равно {result}");
}
else
{
    Console.WriteLine($"Число не натуральное");
}
