// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0.

// метод заполнения массива случайными числами:
int[] GerArrayRandomDigits (int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

// метод вывода массива на консоль:
void PrintArrayToCons(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// метод подстчета суммы элементов на нечетных позициях:
int CountSumNumbersOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

var array = new int[10];
GerArrayRandomDigits(array);
PrintArrayToCons(array);

int result = CountSumNumbersOddIndex(array);
Console.WriteLine($"Сумма элементов с нечетными индексами = {result}.");

