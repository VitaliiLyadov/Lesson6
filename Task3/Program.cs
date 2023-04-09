// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

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

int numb = ReadInt("Введите число");

int[] Binary(int numb)
{
    int[] array = new int[10];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = numb % 2;
        numb = numb / 2;
    }
    return array;
}

PrintArray(Binary(numb));