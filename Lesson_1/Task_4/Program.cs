// Программа, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Вы ввели число ");
Console.WriteLine(number);

int counter = 1;
while (counter <= number)
{
    if (counter % 2 == 0)
    {    
        Console.Write(counter);
        Console.Write(", ");  
    } 
    counter += 1;
}
Console.WriteLine();