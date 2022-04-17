/* Задача 4: Разверните число при помощи рекурсии: N = 1234 -> "4321" */

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void Reverse(int N)
{
    if (N == 0) return;
    Console.Write(N % 10);
    Reverse(N / 10);

}

int N = Promt("Введите N => ");
Reverse(N);