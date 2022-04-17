// Задача 3: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

int[] FreqElem(int[,] array)
{
    int[] arr = new int[10];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arr[array[i, j]]++;
            //switch (array[i, j])
            //{
            //case 0:
            // arr[0] = arr[0] + 1;
            // break;
            //  case 1:
            //      arr[1] = arr[1] + 1;
            //      break;
            // case 2:
            //      arr[2] = arr[2] + 1;
            //      break;
            //  case 3:
            //      arr[3] = arr[3] + 1;
            //      break;
            //   case 4:
            //      arr[4] = arr[4] + 1;
            //      break;
            //  case 5:
            //      arr[5] = arr[5] + 1;
            //      break;
            //  case 6:
            //      arr[6] = arr[6] + 1;
            //      break;
            //  case 7:
            //     arr[7] = arr[7] + 1;
            //      break;
            //  case 8:
            //      arr[8] = arr[8] + 1;
            //      break;
            //  case 9:
            //      arr[9] = arr[9] + 1;
            //       break;
            //    default:
            //         break;
            //   }
        }
    }
    return arr;
}


int[,] array = FillArray(4, 4);
PrintArray(array);
Console.WriteLine();

int[] OutArr = FreqElem(array);
//printArr(OutArr);

for (int i = 0; i < 10; i++)
{
    if (OutArr[i] > 0)
        Console.WriteLine(i + " встречается " + OutArr[i] + " раза");
}

