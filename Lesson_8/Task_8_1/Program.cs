// Программа упорядочивает по убыванию элементы каждой строки двумерного массива.

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

int [,] OrderedArray(int [,] primaryArray)
{
    for (int j = 0; j < primaryArray.GetLength(1); j++)
    {
        for (int i = 0; i < primaryArray.GetLength(0); i ++)
        {
            int max = primaryArray[i, j];
            int iMax = i;
            int count = i;
            while (count < primaryArray.GetLength(0))
            {
                if (primaryArray[count, j] > max)
                {
                    max = primaryArray[count, j];
                    iMax = count;
                }
                count ++;
            }
            if (i != iMax)
            {
                primaryArray[iMax, j] = primaryArray[i, j];
                primaryArray[i, j] = max;
            }
        }
    }
    return primaryArray;
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

int [,] initialArray = CreatArray();
Console.WriteLine("Был создан следующий массив:");
WriteArray(initialArray);
int [,] finalArray = OrderedArray(initialArray);
Console.WriteLine("Массив был преобразован в следующий:");
WriteArray(finalArray);

