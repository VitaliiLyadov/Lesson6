//  Задача 4: Напишите программу, которая будет создавать 
//  копию заданного массива с помощью поэлементного копирования.

int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}
int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}

int[] Copy(int[] massive)
{
    int[] copyArray = new int[massive.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        copyArray[i] = massive[i];
    }
    return copyArray;
}

int len = ReadInt("Введите длину массива");
int minRnd = ReadInt("Введите границу минимума случайной ведичины");
int maxRnd = ReadInt("Введите границу максимума случайной ведичины");
int[] origin = CreateArray(len, minRnd, maxRnd);

// int[] array = origin;
origin[0] = 100;

PrintArray(origin);
PrintArray(Copy(origin));


