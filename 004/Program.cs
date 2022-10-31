// Написать программу копирования массива

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

void CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
}


int[] array = new int[10];
Console.WriteLine("Исходный массив");
FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Скопированный массив");
CopyArray(array);
PrintArray(array); 
