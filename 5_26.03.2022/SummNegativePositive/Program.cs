// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.


int Sum(int[] arr, bool positive)
{
    int direction;
    if (positive)
    {
        direction = 1;
    }
    else
    {
        direction = -1;
    }

    int sum = 0;
    foreach (int element in arr)
    {
        if (element * direction > 0)
        {
            sum += element;
        }
    }
    return sum;
}

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-9, 10);
    }
    return answer;
}

void console(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine();
}

int[] arr = RandArray(12);
console(arr);
int sumNegative = Sum(arr, false);
int sumPositive = Sum(arr, true);
Console.WriteLine($"Сумма отрицательных = {sumNegative}, сумма положительных = {sumPositive}");