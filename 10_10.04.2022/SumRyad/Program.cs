/* Задача 1: Напишите программу, которая на вход принимает два числа 
и выдаёт первые N чисел, для которых каждое следующее равно сумме 
двух предыдущих.*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int Sum(int A, int B, int N)
{

    if (N == 0) return 0;
    Console.Write(A + " ");
    return A + Sum(B, A + B, N - 1);

}

int A = Promt("Введите первое число => ");
int B = Promt("Введите второе число => ");
int N = Promt("Сколько чисел должна вывести программа => ");
//Console.Write(A + " " + B + " ");
Sum(A, B, N);