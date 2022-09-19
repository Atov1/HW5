// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

int [] array = new int[8];

void DiffInArray(int [] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length-1)
    {
        arr[index] = new Random().Next(1,100);
        Console.Write($"{arr[index]}, ");
        index++;  
    }
        arr[index] = new Random().Next(1,100);
        Console.Write($"{arr[index]} ->");
    int max = 0;    //c этого момента должен был быть новый метод...
    int min = 100; //последнее из возможных чисел в массиве
    foreach (var el in arr) 
    {
        if (el<min)
        {
            min = el;
        }
    }
    foreach (var el in arr)
    {
    if (el>max)
    {
        max = el;
    }
    }
    int dif = max-min;
    Console.Write($" {dif}");
}
DiffInArray(array);

