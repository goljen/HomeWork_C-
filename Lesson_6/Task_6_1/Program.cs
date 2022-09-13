// Программа обеспчивает ввод пользователем с клавиатуры M чисел и 
// считает, сколько чисел больше 0 ввёл пользователь.

int AmountNumbers() // Получение количества чисел вводимых пользователем.
{
    Console.Write("Введите количество чисел, которые Вы предполагаете вводить: ");
    int number = Convert.ToInt32(Console.ReadLine());
    while (number <= 0)
    {
        Console.Write("ОШИБКА!!! Количество чисел должно быть больше 0. ");
        Console.Write("Введите количество чисел, которые Вы предполагаете вводить: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
double [] InputArray(int number)
{
    double [] array = new double[number];
    for(int i = 0; i < number; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

int CountingPositiveNumbers(double [] array, int number)
{
    //int sizeArray = array.Lenght;
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        if (array[i] >= 0) count++;
    }
    
    return count;
}

// Основное тело программы

int  enteredNumber = AmountNumbers();
double [] inputNumbers = new double[enteredNumber];
inputNumbers = InputArray(enteredNumber);
int countPositiveNumbers = CountingPositiveNumbers(inputNumbers, enteredNumber);
Console.WriteLine($"Количество положительных чисел среди {enteredNumber} введённых равно {countPositiveNumbers}");
