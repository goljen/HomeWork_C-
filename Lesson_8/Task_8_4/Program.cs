// Программа выводит трёхмерный массив из неповторяющихся двузначных чисел, 
// добавляя индексы каждого элемента.

void WriteArray(int [,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})");
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    } 
}

int [,,] threeDimensionalArray = { //инициализация трехмерного массива целых чисел 2x2x2
                                    {
                                        {25, 33},
                                        {45, 55}
                                    },
                                    {
                                        {13, 76},
                                        {62, 83}
                                    }
                                };


        WriteArray(threeDimensionalArray);
