// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.Write("Таблица кубов чисел от 1 до  ");
Console.WriteLine(number);
while (count <= number)
{
   Console.Write(Math.Pow(count, 3));
   Console.Write(", ");
   count ++;
}
Console.WriteLine();