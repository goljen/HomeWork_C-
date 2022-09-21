// Программа выводит все натуральные числа в промежутке от M до N.


Console.Write("Введите число M:");
double minNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число N:");
double maxNumber = Convert.ToDouble(Console.ReadLine());
while(maxNumber <= minNumber || minNumber < 0 || maxNumber < 0)
{
    Console.WriteLine("ОШИБКА!!!");
    Console.WriteLine("Числа M и N не могут быть отрицательными, а также число М не может быть больше или равно N");
    Console.WriteLine("Попробуйте ещё раз.");
    Console.Write("Введите число M:");
    minNumber = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число N:");
    maxNumber = Convert.ToDouble(Console.ReadLine());
}

int n = (int)maxNumber;
int m = (int)minNumber;

Console.Write("Натуральные числа от M до N: \"");
for (int i = m; i <= n; i++)
{
    Console.Write(i);
    if (i != n)
    {
       Console.Write(", "); 
    }
}

Console.WriteLine("\"");
