

// 1. Задайте массив из 12 элементов и найдите сумму отрицательных элементов
/*
//1.Метод создания массива
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
//2.метод вывода массива на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
//3.метод определения отрицательных элементов и вычисление их суммы
int GetNegativSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]< 0) sum += array[i];
    }
    return sum;
}
//4. Программа
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

//2. необходимо написать программу замены элементов массива: положительные заменить 
//на отрицательные и наоборот
/*
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
*/


//3. напишите программу которая определяет есть ли заданное число в массиве
//bool метод.
/*
//Метод создания массива
int[] CreateRandomArray(int size, int minVaue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minVaue, maxValue + 1);
    return array;
}
//Метод сравнения введенного числа с элементами массива
bool SearchNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(number==array[i]) return true;

    }
    return false;
    
}
//Метод вывода на экран

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
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateRandomArray(length, min, max);
ShowArray(myarray);
Console.WriteLine(" ");
Console.WriteLine(SearchNumber(myarray, number));
*/

//4. задайте массив из m случайных чисел. найдите количество элементов, которые лежат в отрезке 
//от a до b [a,b];
/*


int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountElements(int[]array, int num1, int num2)
{
    int count = 0;
    for(int i=0;i<array.Length; i++)
    {
        if(array[i]>num1 && array[i]<num2)
        count++;
    }
return count;
}

Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение минимального элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateArray(length,min,max);
ShowArray(myarray);

Console.WriteLine("Введите число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = CountElements(myarray, num1,num2);
Console.WriteLine($" There are " +(result)+ " numbers ");