// Программа, которая на вход принимает число и выдаёт, является ли число чётным. 

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Вы ввели число ");
Console.WriteLine(number);
if (number % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(number);
    Console.WriteLine(" четное");
}
else
{
    Console.Write("Число ");
    Console.Write(number);
    Console.WriteLine(" нечетное"); 
}