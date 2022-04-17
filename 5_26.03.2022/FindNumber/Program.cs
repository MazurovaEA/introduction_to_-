// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber(int[] arr, int Value)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == Value) 
        {result = true;
        break;}
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
int[] arr = RandArray(len);
PrintArray(arr);
Console.WriteLine();
int number = Prompt("Введите число => ");
Console.WriteLine(FindNumber(arr, number));