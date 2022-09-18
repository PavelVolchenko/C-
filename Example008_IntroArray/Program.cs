void FillArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = new Random().Next(1, 101);
        index++;
    }
}

void PrintArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write($"{array[index]} ");
        index++;
    }
    Console.WriteLine();
}

void MinMax(int[] array)
{
    int index = 1;
    int size = array.Length;
    int max = array[0], min = array[0],
    maxIndex = 0, minIndex = 0;
    while(index < size)
    {
        if(array[index] > max)
        {
            max = array[index]; 
            maxIndex = index;
        }
        if(array[index] < min)
        {
            min = array[index];
            minIndex = index;
        }
        index++;
    }
    Console.WriteLine($"Минимальное число: {min} индекс {minIndex}");
    Console.WriteLine($"Максимальное число: {max} индекс {maxIndex}");
}

int[] arr = new int[20];

FillArray(arr);
PrintArray(arr);
MinMax(arr);