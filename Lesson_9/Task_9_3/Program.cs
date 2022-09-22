// Программа вычисляет функцию Аккермана для двух неотрицательных числа m и n.

int AckermanFunction (int m, int n)
{
    int result = 0;
    if (m == 0) result = n + 1;
    else if (n == 0) result = AckermanFunction (m - 1, 1);
    else result = AckermanFunction (m - 1, AckermanFunction (m, n-1));
    return result;
}



Console.Write("Введите целое неотрицательное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое неотрицательное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
while(numberN < 0 || numberM < 0)
{
    Console.WriteLine("ОШИБКА!!!");
    Console.WriteLine("Числа M и N не могут быть отрицательными.");
    Console.WriteLine("Попробуйте ещё раз.");
    Console.Write("Введите целое неотрицательное число M:");
    numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое неотрицательное число N:");
    numberN = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
int functionValue = AckermanFunction (numberM, numberN);
Console.WriteLine("Значение функции Аккермана (A(m,n))");
Console.WriteLine($"для m = {numberM} и n = {numberN} равно {functionValue}");
Console.WriteLine();

