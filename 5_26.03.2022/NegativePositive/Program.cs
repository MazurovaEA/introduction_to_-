// Задача 1: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, 
//и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-9, 10);
    }
    return answer;
}

void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ",");

    }
    Console.Write(collect[collect.Length - 1] + "]");
}

int[] Reverse(int[] arr)
{
    for (int i = 0; i <= arr.Length-1; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

int[] arr = RandArray(12);
PrintArray(arr);
int[] arr1 = Reverse(arr);
PrintArray(arr1);