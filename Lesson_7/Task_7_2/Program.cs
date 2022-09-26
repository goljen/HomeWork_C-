// Программа принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void ReadArrayElementPositions(out int row, out int column)
{
    Console.Write("Введите номер строки массива:");
    row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца массива:");
    column = Convert.ToInt32(Console.ReadLine());
    while(row <= 0 || column <= 0)
    {
        Console.WriteLine("ОШИБКА!!!");
        Console.WriteLine("Количество строк и столбцов массива должно быть больше 0 ");
        Console.WriteLine("Попробуйте ещё раз.");
        Console.Write("Введите номер строки массива:");
        row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца массива:");
        column = Convert.ToInt32(Console.ReadLine());
    }
}

void ValueArrayElement(int [,] array, int row, int column)
{
    if (row >= array.GetLength(1) || column >= array.GetLength(0))
    {
        Console.WriteLine($"Элемента с позицией [{row}, {column}] в этом массисве не существует");
    }
    else
    {
        Console.WriteLine($"Значение элемента с позицией [{row}, {column}] равно {array[column - 1, row - 1]}");
    }
}

int rowValue;
int columnValue;
int [,] newArray = CreatArray();
WriteArray(newArray);
ReadArrayElementPositions(out rowValue, out columnValue);
ValueArrayElement(newArray, rowValue, columnValue);

