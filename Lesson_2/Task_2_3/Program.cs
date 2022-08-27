// Программа, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите число, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Вы ввели число ");
Console.WriteLine(number);

if (number == 6 || number == 7)
    Console.WriteLine("Это выходной день");
else
    Console.WriteLine("Это рабочий день");