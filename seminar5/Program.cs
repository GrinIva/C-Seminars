

// Задайте массив из 12 элементов и найдите сумму отрицательных элементов
/*
//Метод создания массива
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
//метод вывода массива на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
//метод определения отрицательных элементов и вычисление их суммы
int GetNegativSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]< 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение минимального элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateRandomArray(length, min, max);
ShowArray(myarray);
Console.WriteLine(" ");
Console.WriteLine(GetNegativSum(myarray));
*/

//необходимо написать программу замены элементов массива: положительные заменить на отрицательные и наоборот

//метод создания массива
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int[size];
    for (int i=0;i<size;i++)
        array[i]=new Random().Next(minValue,maxValue+1);
    return array;
}
//метод преобразования массива
int [] RecreateArray(int[] array, int multiplier)
{
    for(int i=0; i<array.Length;i++)
        array[i]=array[i]* multiplier;
    return array;
}
//метод вывода массива на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение минимального элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент преобразования массива: ");
int multiplier = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateRandomArray(length, min, max);
ShowArray(myarray);
Console.WriteLine(" ");
RecreateArray(myarray, multiplier);
ShowArray(myarray);

//задайте массив. напишите программу которая определяет есть ли заданное число в массиве
//bool метод

//задайте массив из m случайных чисел. найдите количество элементов, которые лежат в отрезке 
//от a до b [a,b];