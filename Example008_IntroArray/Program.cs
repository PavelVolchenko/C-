void FillArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = new Random().Next(-100, 101);
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
}

int Max(int[] array)
{
    int index = 1;
    int size = array.Length;
    int max = 0;
    while (index < size)
    {
        if(array[index] > max)
        {
            max = array[index];
        }
        index++;
    }
    return max;
}

int[] arr = new int[20];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Console.Write($"Максимальное число: {Max(arr)}");