// Программа, которая показывает количество чётных чисел в массиве, 
// заполненным случайными положительными трёхзначными числами.

int [] CreatArray(int size) // Создание массива, заполненным случайными положительными трёхзначными числами.
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}   

void WriteArray(int [] array) // Вывод массива на экран.
{
    int count = array.Length;
    Console.Write($"массив из {count} элементов: ");
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

int CountEvenNumbers(int [] array) // Определние количества чётных чисел в массиве.
{
    int count = array.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] % 2 == 0) result ++;
    }
    return result;
}

int ReadArraySize() // Ввод размера массива
{
    Console.Write("Введите размер массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    while (number <= 0)
    {
        Console.Write("ОШИБКА!!! Размер массива должен быть больше 0. ");
        Console.Write("Введите размер массива: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

// Основное тело программы

int arraySize = ReadArraySize();
int [] RandomAarray = new int [arraySize];
RandomAarray = CreatArray(arraySize);
Console.Write("Создан ");
WriteArray(RandomAarray);
int countnumders = CountEvenNumbers(RandomAarray);
Console.WriteLine($"Количество четных чисел в массиве равно {countnumders}");

