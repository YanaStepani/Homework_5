// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

// метод заполнения массива вещественными числами (как я поняла - это тип double):
double[] GerArrayRandomDigits (double[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

// метод вывода массива на консоль:
void PrintArrayToCons(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// метод поиска разницы между максимальным и минимальным числами:
double SubtractionMaxMin(double[] array)
{
    var max = array[0];
    var min = array[0];
    double substraction = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    substraction = max - min;
    return substraction;
}

double[]  array = new double[10];
GerArrayRandomDigits(array);
PrintArrayToCons(array);

var result = SubtractionMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным числом = {result}.");
