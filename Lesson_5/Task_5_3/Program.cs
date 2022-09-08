// Программа расчитывает разницу между максимальным и минимальным 
// элементами массива, заполненого случайными одно- и двузначными числами.


int [] CreatArray(int size) // Создание массива, заполненным случайными положительными одно- и двузначными числами.
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}   

void WriteArray(int [] array) // Вывод массива на экран.
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

int MaxElement(int [] array) // Определние максимального значения элементов массива.
{
    int count = array.Length;
    int max = array[0];
    for (int i = 0; i < count; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int MinElement(int [] array) // Определние минимаьного значения элементов массива.
{
    int count = array.Length;
    int min = array[0];
    for (int i = 0; i < count; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
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
Console.WriteLine("Создан следующий массив:");
WriteArray(RandomAarray);
int maxelement = MaxElement(RandomAarray);
int minelement = MinElement(RandomAarray);
int diffvalues = maxelement - minelement;
Console.WriteLine($"Разница max и min занчений элементов массива равна {diffvalues}");

