// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое положительное число: ");
string number = Convert.ToString(Console.ReadLine());
Console.Write("Вы ввели число ");
Console.WriteLine(number);

if (number.Length < 3)
    Console.WriteLine("Третьей цифры в числе нет.");
else
{
    char digit3 = number[2];
    Console.Write("Третья цифра в числе равна ");
    Console.WriteLine(digit3);
}
    