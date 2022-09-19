// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
        arr[index] = new Random().Next(1, 11);
        Console.Write($"{arr[index]},");
        index++;  
    }
        arr[index] = new Random().Next(1, 11);
        Console.Write($"{arr[index]}");

    Console.Write("]");
    int sum = 0;    //c этого момента должен был быть новый метод...
    index = 0;
    while (index < n) 
    {
        if (index%2==0)
        {sum = sum + array[index];}
    index++;        
    }
    Console.Write($"-> {sum}");
}

Done(array);
