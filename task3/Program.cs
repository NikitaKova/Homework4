// Задача 3: Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 7, 8


int [] CreateMassiv()
{
    int [] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
        Console.Write($"{array[i]} ");
    }
    return array;
} 

//void PrintArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write($"{array[i]}");
//    }
//}
int[] arr = CreateMassiv();
//PrintArray(arr);