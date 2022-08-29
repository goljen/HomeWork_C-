// Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int[] point_1 = new int[3];
int[] point_2 = new int[3];
Console.WriteLine("Введите координаты двух точек.");
Console.WriteLine("Точка 1:");
Console.Write("Координата Х: ");
point_1[0]= Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y: ");
point_1[1]= Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Z: ");
point_1[2]= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Точка 2:");
Console.Write("Координата Х: ");
point_2[0]= Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Y: ");
point_2[1]= Convert.ToInt32(Console.ReadLine());
Console.Write("Координата Z: ");
point_2[2]= Convert.ToInt32(Console.ReadLine());

double length_segment = Math.Sqrt(Math.Pow((point_2[0] - point_1[0]), 2) + 
Math.Pow((point_2[1] - point_1[1]), 2) + Math.Pow((point_2[2] - point_1[2]), 2));

Console.Write("Расстояние между точками = ");
Console.WriteLine(length_segment);
