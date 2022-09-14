// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве. [6, 7, 3, 6] -> 36 21

int[] array = new int[] {10, 10, 2, 4, 5, 10, 9};

int[] MultFirstAndEndNumbers(int[] array)
{
    // создание "половинчатого" массива для хранения выходных данных:
    int size = 0;
    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
    }
    else 
    {
        size = array.Length / 2 + 1;
    }
    int[] newArray = new int[size];

    // поиск произведений чисел:
    int mult = 1;
    for (int i = 0, j = array.Length - 1; i <= j; i++, j--) 
    // в массивах с нечетным количеством элементов, при условии i < j у меня почему-то 
    // программа в массив впысывала среднее значение умноженное на себя, поэтому прищлось добавить if (i == j) 
    {
        if (i == j)
        {
            newArray[i] = array[i];
            break;
        }

        mult = array[i] * array[j];
        newArray[i] = mult;
    }  
       return newArray;
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

int[] newArray = MultFirstAndEndNumbers(array);
PrintArrayToConsole(newArray);
