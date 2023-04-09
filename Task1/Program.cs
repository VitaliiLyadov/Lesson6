// Задача 1: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

double[] CreateArray(int length, int minRnd, int maxRnd)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rnd.Next(minRnd, maxRnd) + rnd.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item:F2}\t");
    }
    System.Console.WriteLine();
}

double[] Reverse(double[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        double tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}

int len = ReadInt("Колличество элементов массива > ");
int minRnd = ReadInt("Минимальное значение > ");
int maxRnd = ReadInt("Максимальное значение > ");
double[] array = CreateArray(len, minRnd, maxRnd);
PrintArray(array);
PrintArray(Reverse(array));
