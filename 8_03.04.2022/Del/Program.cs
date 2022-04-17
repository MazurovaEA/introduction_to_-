// Задача 4: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

(int, int) FindMin(int[,] array)
{
    int minR = 0;
    int minC = 0;
    int minElem = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minElem > array[i, j])
            {
                minElem = array[i, j];
                minR = i;
                minC = j;
            }
        }
    }
    return (minR, minC);
}

int[,] NewArray(int[,] array, int minR, int minC)
{
    int[,] arr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i < minR && j < minC)
                arr[i, j] = array[i, j];
            if (i > minR && j > minC)
                arr[i - 1, j - 1] = array[i, j];
            if (i > minR && j < minC)
                arr[i - 1, j] = array[i, j];
            if (i < minR && j > minC)
                arr[i, j-1] = array[i, j];
        }
    }
    return arr;
}

int[,] array = FillArray(4, 4);
PrintArray(array);
(int minR, int minC) = FindMin(array);
Console.WriteLine("minR = " + (minR + 1));
Console.WriteLine("minC = " + (minC + 1));
Console.WriteLine();
int[,] arr = NewArray(array, minR, minC);
PrintArray(arr);