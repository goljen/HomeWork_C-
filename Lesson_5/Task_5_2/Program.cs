// Программа, вычисляющая сумму элементов одномерного массива, 
// заполненного случайными однозначными и двузначными числами, 
// стоящих на его нечётных позициях.

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

int SuumOddElements(int [] array) // Определние суммы нечетных элементов массива.
{
    int count = array.Length;
    int summa = 0;
    for (int i = 0; i < count; i++)
    {
        if (i % 2 != 0) summa +=array[i];
    }
    return summa;
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
int sumelements = SuumOddElements(RandomAarray);
Console.WriteLine($"Сумма нечетных элементов массива равна {sumelements}");
