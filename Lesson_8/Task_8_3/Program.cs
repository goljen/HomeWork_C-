// Программа, которая вычисляет произведение двух матриц.

int [,] MatrixProduct (int [,] array1, int [,] array2)
{
    int [,] array3 = new int [array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(0); k++)
            {
            array3[i, j] = array3[i, j] + array1[i, k] * array2[k, j];
            }
        }

    }
    return array3;
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

int [,] firstArray = {{2, 3},{4, 2}};
int [,] secondArray = {{3, 3},{4, 3}};  
if (firstArray.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine("Матрицы на совместимы, их произведение не возможно!");
    }
    else
    {
        int [,] resultArray = MatrixProduct (firstArray, secondArray);
        WriteArray(resultArray);
    }



