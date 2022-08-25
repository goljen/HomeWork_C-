// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите два целых числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваши два целых числа: ");
Console.Write(number1);
Console.Write(" ");
Console.WriteLine(number2);
if (number1 > number2)
{
    Console.Write("Число ");
    Console.Write(number1);
    Console.Write(" больше числа ");
    Console.WriteLine(number2);
}
else if(number1 < number2)
{
    Console.Write("Число ");
    Console.Write(number2);
    Console.Write(" больше числа ");
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine("Введенные числа равны");
    
}