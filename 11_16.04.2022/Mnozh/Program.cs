/*Задача 3: Разложите число на множители. Желательно использовать рекурсию:
N = 12 -> "2, 2, 3"*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void Del(int N, int D)
{
    if (N / D == 0) return;
    if (N % D == 0)
    {
        Console.Write(D + " ");
        Del(N / D, D);
    }
    else Del(N, D + 1);
}

int N = Promt("Введите N => ");
Del(N, 2);
