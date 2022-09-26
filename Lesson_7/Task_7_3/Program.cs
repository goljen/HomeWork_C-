// Программа находит среднее арифметическое элементов в каждом столбце массива.

int [,] CreatArray()
{
    int [,] array = {
        {1, 5, 8},
        {4, 9, 4},
        {7, 2, 2},
        {2, 3, 4}
    };
    return array;
}

void WriteArray(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i ++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");  
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanColumnArray(int [,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(0); i ++) 
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j]; 

        }
        Console.Write(Math.Round(sum / array.GetLength(1), 1));
        if (i < array.GetLength(0) - 1) Console.Write("; ");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}
    


int [,] newArray = CreatArray();
WriteArray(newArray);
ArithmeticMeanColumnArray(newArray);


