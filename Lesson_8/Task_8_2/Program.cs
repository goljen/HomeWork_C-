// Программа, которая находит строку с наименьшей суммой элементов
// в прямоугольном двумерном массиве. 

int [,] CreatArray()
{
    int [,] array = {
        {1, 5, 8, 5},
        {4, 9, 4, 2},
        {7, 2, 2, 6},
        {2, 3, 4, 7}
    };
    return array;
}
int  SumLineElements(int [,] Array)
{
    int line = 0;
    int minSumm = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < Array.GetLength(0); i ++)
        {
            summ += Array[i, j]; 
        }
        if (j == 0) 
        {
            minSumm = summ;
        }
        else
        {
            if(summ < minSumm)
            {
                minSumm = summ;
                line = j;
            }
        }
    }
    return line;
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
int numberLine = SumLineElements(initialArray);
Console.WriteLine($"Минимальная сумма элементов в {numberLine + 1} строке");


