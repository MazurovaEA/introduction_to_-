/* Задача 1: Задайте значение N. 
   Напишите программу, которая выведет все натуральные числа 
   в промежутке от 1 до N.*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void PrintN(int i, int N)
{
    if (i > N) return;
    Console.Write(i + " ");
    PrintN(i + 1, N);
}

int N = Promt("Введите N => ");
PrintN(1, N);