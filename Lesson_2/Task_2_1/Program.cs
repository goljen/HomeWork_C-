// Программа, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

Console.Write("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Вы ввели число ");
Console.WriteLine(number);

int digit2_3 = number / 10;
int digit2 = digit2_3 % 10;
Console.Write("Вторая цифра числа ");
Console.Write(number);
Console.Write(" = ");
Console.WriteLine(digit2);

