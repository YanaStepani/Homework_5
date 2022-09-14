// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

// метод заполнения массива случайными числами:
int[] GerArrayRandomThreeDigits (int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

// метод вывода массива на консоль:
void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// метод подстчета количества четных чисел:
int CountEvenNumbers(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

int[] array = new int[10];
GerArrayRandomThreeDigits(array);
PrintArrayToConsole(array);

int result = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {result}.");
