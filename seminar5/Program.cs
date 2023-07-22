

// Задайте массив из 12 элементов и найдите сумму отрицательных элементов


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ")

    Consol.WriteLine();
}

Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение минимального элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateRandomArray(length, min, max);
ShowArray(myarray);