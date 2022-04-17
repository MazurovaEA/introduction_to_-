// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
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

int[,] RowColumn(int[,] array)
{
    int[,] arr = new int[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arr[i, j] = array[j, i];
            //array[i, j] = array[j, i];
            //array[j, i] = arr[i, j];
        }
    }
    return arr;
}

void PrintReverseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            Console.Write($"{array[j, i]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(4, 4);
PrintArray(array);
Console.WriteLine();
//PrintArray(RowColumn(array));
PrintReverseArray(array);
