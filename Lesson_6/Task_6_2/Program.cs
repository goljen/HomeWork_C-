// Программа, которая находит точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.

double [,] ReadCoefficientsFunction ()
{
    double [,] array = new double [2,2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            if(j == 0)
            {
                Console.Write( $"Введите коэффициент {i + 1} функции: ");
                array[i, j] = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.Write( $"Введите смещение {i + 1} функции: ");
                array[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }  
    }
    return array;
}

void WriteArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");  
        }
        Console.WriteLine();
    }
}

double [,] PointIntersectionFunctions(double [,] array)
{
    double [,] point = new double [1,2];
    point[0,0] = (array[0,1] - array[1,1]) / (array[1,0] - array[0,0]);
    point[0,1] = point[0,0] * array[0,0] + array[0,1];
    return point;
}

double [,] coefficientsFunction = ReadCoefficientsFunction ();
WriteArray(coefficientsFunction);
double [,] pointIntersection = PointIntersectionFunctions(coefficientsFunction);
Console.WriteLine($"Точка пересечения ({pointIntersection[0,0]}, {pointIntersection[0,1]})");
