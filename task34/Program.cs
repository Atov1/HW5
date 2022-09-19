// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int [] array = new int [Math.Abs(n)];


void Done(int [] arr)
{
    int length = arr.Length;
    int index = 0;
    Console.Write("[");
    while (index < length-1)
    {
        arr[index] = new Random().Next(100, 1000);
        Console.Write($"{arr[index]},");
        index++;  
    }
        arr[index] = new Random().Next(100, 1000);
        Console.Write($"{arr[index]}");

    Console.Write("]");
    int sum = 0;    //c этого момента должен был быть новый метод...
    index = 0;
    while (index < n)
    {
        if (array[index]%2==0)
        {sum++;}
    index++;        
    }
    Console.Write($"-> {sum}");
}

Done(array);