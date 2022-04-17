
// void printPascal(int n)
// {
//     for (int line = 0; line < n; line++)
//     {
//         for (int i = 0; i <= line; i++)
//             Console.Write(binomialCoeff(line, i) + " ");
//         Console.WriteLine();
//     }
// }

// int binomialCoeff(int n, int k)
// {
//     int res = 1;
//     if (k > n - k)
//         k = n - k;
//     for (int i = 0; i < k; ++i)
//     {
//         res *= (n - i);
//         res /= (i + 1);
//     }
//     return res;
// }

// printPascal(7);

// int n = 5;
// int[,] arr = new int[n, n];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         if (i == j || j == 0) arr[i, j] = 1;
//         else arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine("");
// }

int i, n, c;
Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
string s = Console.ReadLine();
n = Convert.ToInt32(s);

int factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
    {
        Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        Console.Write(" "); // создаём пробелы между элементами треугольника
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
    }
    Console.WriteLine();
    Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
}
