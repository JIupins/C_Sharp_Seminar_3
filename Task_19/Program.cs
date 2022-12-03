// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int FlipNumber(int num)
{
    int newNum = default;
    while (num > 0)
    {
        int bufer = num % 10;
        newNum = newNum * 10 + bufer; // Почему не работает составной оператор присваивания "newNum *= 10 + bufer;"? Подозреваю что он думает что "newNum = newNum * (10 + bufer);"
        num /=10;
    }
    return newNum;
}

void CompareNumbers(int oneNum, int twoNum)
{
    if (oneNum == twoNum) Console.WriteLine ($"Введеное число {oneNum} является полиндромом!");
    else Console.WriteLine ($"Введеное число {oneNum} не является полиндромом!");
}

Console.Write("Введите пятизначное число: ");
int mainNumber = Convert.ToInt32(Console.ReadLine());

int reverseNumber = FlipNumber (mainNumber);
CompareNumbers (mainNumber, reverseNumber);