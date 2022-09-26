//  Программа создает двумерный массив размером m×n, заполненный случайными
//  вещественными числами.

double [,] CreateArray(int number1, int number2)
{
    double [,] array = new double[number1, number2];
    for(int i = 0; i < number1; i++)
    {
        for(int j = 0; j < number2; j++)
        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
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

void ReadArrayParameters(out int rows, out int columns)
{
    Console.Write("Введите количество строк массива:");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива:");
    columns = Convert.ToInt32(Console.ReadLine());
    while(rows <= 0 || columns <= 0)
    {
        Console.WriteLine("ОШИБКА!!!");
        Console.WriteLine("Количество строк и столбцов массива должно быть больше 0 ");
        Console.WriteLine("Попробуйте ещё раз.");
        Console.Write("Введите количество строк массива:");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива:");
        columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество строк массива:");
    }
}
int numberRows;
int numberColumns;
ReadArrayParameters(out numberRows, out numberColumns);
double [,] newArray = CreateArray(numberRows, numberColumns);
WriteArray(newArray);