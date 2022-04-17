// Задача 3: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат 
// в отрезке [10,99]. 

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 1000);
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
int FindColl(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            result++;
    }
    return result;
}
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int len = Prompt("Введите длину массива => ");
if (len != 123) Console.WriteLine("Читай задание! Длина массива должна быть 123!!!");
else
{
    int[] arr = RandArray(len);
    PrintArray(arr);
    Console.WriteLine();
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {FindColl(arr)}");
}