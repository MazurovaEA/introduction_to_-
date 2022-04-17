/*Задача 4: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int Stepen(int A, int B)
{
    if (B == 0) return 1;
    return A * Stepen(A, B - 1);
}


int A = Promt("Введите число A => ");
int B = Promt("Введите число B => ");
Console.WriteLine(Stepen(A,B));