//напишите программу которая перевернет массив
/*
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

void RevArray(int[]array)
{
    for(int i=0;i<array.Length/2;i++) 
    {
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;

    }
 //   for(int i=0, j=array.Length-1-i;i<j;i++,j--)
 //   {
 //       int temp = array[i];
 //       array[i]=array[j];
 //       array[j]=temp;
 //   }


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
RevArray(myarray);
ShowArray(myarray);
*/



//напишите программу, которая принимает на вход
//3 числа и проверят может ли существовать треугольник со сторонами такой длинны
/*
bool CheckTrin(int []array)
{
    
    if(array[0]<array[1]+array[2]&&array[1]<array[0]+array[2]&&array[2]<array[1]+array[0])
    return true;
    else return false;
}

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int[] myarray = {a,b,c};
Console.WriteLine(CheckTrin(myarray));
*/

//не используя рекурсию нужно вывести первые n-чисел фибоначи
/*
int []CreateFibonachiArray(int size,int a,int b)
{
    int []array = new int[size];
    array[0]=a;
    array[1]=b;
    for(int i=2;i<size;i++)
        array[i]=array[i-1]+array[i-2];
    return array;
}

void ShowArray(int []array)
{
    for(int i=2;i<array.Length;i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

Console.WriteLine("Введите первое число последовательности: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число последовательности: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите желаемое количество элементов последовательности: ");
int length = Convert.ToInt32(Console.ReadLine());
int []myarray = CreateFibonachiArray(length+2,a,b);
ShowArray(myarray);
*/


//напишите программу которая будет создавать копию заданного массива
//с помощью поэлементного копирования

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] copyarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyarray[i] = array[i];

    return copyarray;

}

Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение минимального элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateRandomArray(length, min, max);
ShowArray(myarray);
CopyArray(myarray);
ShowArray(CopyArray(myarray));