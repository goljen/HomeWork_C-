// Программа, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreatArray(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}   

void WriteArray(int [] array)
{
    int count = array.Length;
    Console.Write($"Массив из {count} элементов: ");
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) 
            Console.Write($"{array[i]}");
        else 
            Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}

Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 0)
    {
        Console.Write("ОШИБКА!!! Размер массива должен быть больше 0. ");
        Console.Write("Введите размер массива: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
int [] RandomAarray = new int [number];
RandomAarray = CreatArray(number);
WriteArray(RandomAarray);

