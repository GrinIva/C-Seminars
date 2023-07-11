

//13254 /10 = 1325
//13254 /100 = 132 
//13254 /1000 = 13
//13254 /10000 = 1

// 13254 % 10 = 
//
//
//


// Программа которая выводит случайное трехзначное число 
// и удаляет вторую цифру данного числа

/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num %10;

    int result = hundreds * 10 + units;
    return result;

}

int randNumber = new Random().Next(100,1000);
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {newNumber}");

// 321 -> 3 1 -> 31

*/



//
// 3.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно а и в
/*
//метод

bool isDividable(int num, int a, int b)
{
    if(num % a == 0 && num % b == 0) return true;
    else return false;
}

Console.Write("input a number for checking");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("input a first div for checking");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second div for checking");
int div2 = Convert.ToInt32(Console.ReadLine());

bool result = isDividable(number, div1, div2);
Console.WriteLine.(sDividable(num));

*/

//
// 4. 
//metod

int HighestNum (int hnum)
{
    int first = hnum / 10;
    int second = hnum % 10;
    if (first > second) return first;
    else return second;
}

int randNumber = new.Random.Next(10,100);
int resNumber = HighestNum(randNumber);
Console.WriteLine(resNumber);
