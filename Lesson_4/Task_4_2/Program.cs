// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadNaturalNumber()
{
    Console.Write("Введите натуральное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    while (number <= 0)
    {
        Console.Write("ОШИБКА!!! Вы ввели не натуральное число. ");
        Console.Write("Введите натуральное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Вы ввели число {number}");
    Console.WriteLine();

    return number;
}

int SumDigit(int num)
{
   int sum = 0;
   while (num > 0) 
   {
        sum += num % 10;
        num /= 10;
   }
   return sum;
}




int a = ReadNaturalNumber();
int SummaDigit = SumDigit(a);
Console.WriteLine($"Сумма цифр числа {a} равна {SummaDigit}");



