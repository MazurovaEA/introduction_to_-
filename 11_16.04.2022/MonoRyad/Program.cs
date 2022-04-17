/* Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
Выведите ряд этой последовательности до N-го значения, желательно использовать : N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" */

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void Ryad(int N, int count, int max)
{
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{N} ");
        count++;
        if (count == max) return;
    }
    Ryad(N + 1, count, max);
}

int N = Promt("Введите N => ");
Ryad(1, 0, N);