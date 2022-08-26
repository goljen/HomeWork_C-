// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три целых числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваши три целых числа: ");
Console.Write(number1);
Console.Write(", ");
Console.WriteLine(number2);
Console.Write(", ");
Console.WriteLine(number3);

int max_number = 0;

if (number1 > number2)
{
    if (number1 > number3) 
    {
        max_number = number1;
    }
    
    else 
    {
        max_number = number3;
    }
}

else 
{
    if (number2 > number3) 
    {
        max_number = number2;
    }
    else 
    {
        max_number = number3;
    }
}

Console.Write("Максимальное число равно ");    
Console.WriteLine(max_number);
