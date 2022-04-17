/* Задача 2: В некотором машинном алфавите имеются четыре
 буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, 
 которые можно построить из букв этого алфавита.*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void FindWord(string str, char[] s, int n = 0)
{
    if (n == s.Length)
    {
        Console.WriteLine($"{n++} {new String (s)}");
        return;
    }
    for (int i = 0; i < str.Length; i++)
    {
        s[n] = str[i];
        FindWord(str, s, n + 1);
    }
}

int N = Promt("Введите кол-во букв в словах => ");
FindWord("аисв", new char[N]);