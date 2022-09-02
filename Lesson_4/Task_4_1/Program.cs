// Программа с применением цикла, которая принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.

int[] ReadNumbers()
{
    int[] Arg = new int[2];
    
    Console.WriteLine("Введите основание и показатель степени.");
    Console.Write("Значение основания степени:");
    Arg[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Значение показателя степени:");
    Arg[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    return Arg;
}

int Exponent(int[] array)
{
    int result = 1;

    for(int i = 0; i < array[1]; i++)
    {
        result = result * array[0];
    }
    return result;
}


int[] ArgExp = new int[2];

ArgExp = ReadNumbers();
int ValExp = Exponent(ArgExp);
Console.WriteLine($"Результат возведения {ArgExp[0]} в степень {ArgExp[1]} равно {ValExp}.");
Console.WriteLine();