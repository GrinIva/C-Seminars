

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