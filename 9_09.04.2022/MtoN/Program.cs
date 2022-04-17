/* Задача 2: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void PrintN(int N, int M)
{
    if (N > M) return;
    Console.Write(N + " ");
    PrintN(N + 1, M);
}

int N = Promt("Введите N => ");
int M = Promt("Введите M => ");
PrintN(N, M);
