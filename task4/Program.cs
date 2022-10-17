//  Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом
//[1, 3, 5, 6, 6, 4] -> 5

int [] Array = { 1, 2, 5, 4, 5, 5};
int max = Array[0];
int secMax = Array[1];

for (int i = 0; i < Array.Length; i++)
{
    if (max < Array[i])
    {
        secMax = max;
        max = Array[i];
    }
    if (secMax == max)
    {
        secMax = Array[i + 1];
    }
    else if (secMax < Array[i] && Array[i] != max)
    {
        secMax = Array[i];
    }
}

Console.WriteLine(max);
Console.WriteLine(secMax);