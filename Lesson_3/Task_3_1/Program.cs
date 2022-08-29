// Программа, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Write("Введите целое положительное пятизначное число: ");
string number = Convert.ToString(Console.ReadLine());
Console.Write("Вы ввели число ");
Console.WriteLine(number);

if (number[0] == number[4] && number[1] == number[3])
    Console.WriteLine("Это полиндром.");
else
    Console.WriteLine("Введённое число не являеться полиндромом.");
