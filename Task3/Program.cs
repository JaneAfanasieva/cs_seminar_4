// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] arr = GetRandomArray(8);
PrintArray(arr);

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for(int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(-20, 21);
    }

    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
