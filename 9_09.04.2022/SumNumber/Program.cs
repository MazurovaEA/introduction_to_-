/* Задача 3: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int SumN(int N)
{
    if (N / 10 <= 0) return N % 10;
    return N % 10 + SumN(N / 10);
}

int N = Promt("Введите число => ");
Console.Write(SumN(N));